using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class TransactionRate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TransactionRate",
                table: "Transactions",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 187, DateTimeKind.Local).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 187, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 187, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 187, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 267, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 268, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 274, DateTimeKind.Local).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 274, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 203, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 203, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 203, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 203, DateTimeKind.Local).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 203, DateTimeKind.Local).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8033));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 214, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 191, DateTimeKind.Local).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 191, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 191, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 191, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 191, DateTimeKind.Local).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 191, DateTimeKind.Local).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 191, DateTimeKind.Local).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(19));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(64));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(331));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(349));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(991));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 192, DateTimeKind.Local).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 254, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 285, DateTimeKind.Local).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 285, DateTimeKind.Local).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 285, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 230, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 230, DateTimeKind.Local).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 230, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 230, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 230, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 230, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 234, DateTimeKind.Local).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 234, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 234, DateTimeKind.Local).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 234, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 248, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 247, DateTimeKind.Local).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 247, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 247, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 247, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 227, DateTimeKind.Local).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 227, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 227, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 196, DateTimeKind.Local).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 196, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 210, DateTimeKind.Local).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 210, DateTimeKind.Local).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 277, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 277, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 277, DateTimeKind.Local).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 277, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 282, DateTimeKind.Local).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 282, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 282, DateTimeKind.Local).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 282, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 282, DateTimeKind.Local).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 282, DateTimeKind.Local).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 282, DateTimeKind.Local).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 282, DateTimeKind.Local).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 282, DateTimeKind.Local).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 282, DateTimeKind.Local).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 282, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 282, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 280, DateTimeKind.Local).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 280, DateTimeKind.Local).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 237, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 237, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 237, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 237, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 237, DateTimeKind.Local).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 237, DateTimeKind.Local).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 237, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 237, DateTimeKind.Local).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9994,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9995,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9996,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9997,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 240, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 177, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 177, DateTimeKind.Local).AddTicks(9718));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 177, DateTimeKind.Local).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 177, DateTimeKind.Local).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 177, DateTimeKind.Local).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9611));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9723));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9734));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9768));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9903));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9991));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 173, DateTimeKind.Local).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(19));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(42));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(48));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(66));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(77));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 218, DateTimeKind.Local).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 218, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 218, DateTimeKind.Local).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 218, DateTimeKind.Local).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 271, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 271, DateTimeKind.Local).AddTicks(5287));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 271, DateTimeKind.Local).AddTicks(5296));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 204, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 204, DateTimeKind.Local).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 204, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 204, DateTimeKind.Local).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 204, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 204, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 204, DateTimeKind.Local).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1935));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1958));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 255, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 174, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 166, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 168, DateTimeKind.Local).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 168, DateTimeKind.Local).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 261, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 261, DateTimeKind.Local).AddTicks(9705));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 261, DateTimeKind.Local).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 261, DateTimeKind.Local).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 287, DateTimeKind.Local).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 287, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 287, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 287, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 287, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 287, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 264, DateTimeKind.Local).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 264, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 264, DateTimeKind.Local).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 264, DateTimeKind.Local).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 264, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 264, DateTimeKind.Local).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 182, DateTimeKind.Local).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 182, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 182, DateTimeKind.Local).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 182, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 182, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 182, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 182, DateTimeKind.Local).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 182, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 234, DateTimeKind.Local).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 234, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 201, DateTimeKind.Local).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 201, DateTimeKind.Local).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 201, DateTimeKind.Local).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 220, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 223, DateTimeKind.Local).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 223, DateTimeKind.Local).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 208, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 208, DateTimeKind.Local).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 208, DateTimeKind.Local).AddTicks(9485));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 208, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 208, DateTimeKind.Local).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 208, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 208, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 208, DateTimeKind.Local).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 18, 18, 48, 208, DateTimeKind.Local).AddTicks(9553));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransactionRate",
                table: "Transactions");

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 417, DateTimeKind.Local).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 417, DateTimeKind.Local).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 417, DateTimeKind.Local).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 417, DateTimeKind.Local).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 472, DateTimeKind.Local).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 472, DateTimeKind.Local).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 478, DateTimeKind.Local).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 478, DateTimeKind.Local).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 426, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 426, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 426, DateTimeKind.Local).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 426, DateTimeKind.Local).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 426, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8495));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 432, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 419, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1252));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1392));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1404));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1416));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(1582));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 489, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 489, DateTimeKind.Local).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 489, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 445, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 445, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 445, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 445, DateTimeKind.Local).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 445, DateTimeKind.Local).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 445, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 448, DateTimeKind.Local).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 448, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 448, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 448, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 459, DateTimeKind.Local).AddTicks(652));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 458, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 458, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 458, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 458, DateTimeKind.Local).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 441, DateTimeKind.Local).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 441, DateTimeKind.Local).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 441, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 422, DateTimeKind.Local).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 422, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 430, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 430, DateTimeKind.Local).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 482, DateTimeKind.Local).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 482, DateTimeKind.Local).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 482, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 482, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 487, DateTimeKind.Local).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 487, DateTimeKind.Local).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 487, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 487, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 487, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 487, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 487, DateTimeKind.Local).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 487, DateTimeKind.Local).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 487, DateTimeKind.Local).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 487, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 487, DateTimeKind.Local).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 487, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 485, DateTimeKind.Local).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 485, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 451, DateTimeKind.Local).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 451, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 451, DateTimeKind.Local).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 451, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 451, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 451, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 451, DateTimeKind.Local).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 451, DateTimeKind.Local).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 453, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 453, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 453, DateTimeKind.Local).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 453, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 453, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 453, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 453, DateTimeKind.Local).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 453, DateTimeKind.Local).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 453, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 453, DateTimeKind.Local).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 453, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 453, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 453, DateTimeKind.Local).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 453, DateTimeKind.Local).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 453, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 453, DateTimeKind.Local).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 453, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 453, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 453, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9994,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 453, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9995,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 453, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9996,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 453, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9997,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 453, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 453, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 453, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 411, DateTimeKind.Local).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 411, DateTimeKind.Local).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 411, DateTimeKind.Local).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 411, DateTimeKind.Local).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 411, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5227));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5273));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5281));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5516));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 408, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 435, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 435, DateTimeKind.Local).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 435, DateTimeKind.Local).AddTicks(1979));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 435, DateTimeKind.Local).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 474, DateTimeKind.Local).AddTicks(9677));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 475, DateTimeKind.Local).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 475, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 426, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 426, DateTimeKind.Local).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 426, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 426, DateTimeKind.Local).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 426, DateTimeKind.Local).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 426, DateTimeKind.Local).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 426, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(6647));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 463, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2256));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2321));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2382));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2457));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2527));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2529));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2551));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2555));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 409, DateTimeKind.Local).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 402, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 404, DateTimeKind.Local).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 404, DateTimeKind.Local).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 468, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 468, DateTimeKind.Local).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 468, DateTimeKind.Local).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 468, DateTimeKind.Local).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 493, DateTimeKind.Local).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 493, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 493, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 493, DateTimeKind.Local).AddTicks(4715));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 493, DateTimeKind.Local).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 493, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 470, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 470, DateTimeKind.Local).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 470, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 470, DateTimeKind.Local).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 470, DateTimeKind.Local).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 470, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 414, DateTimeKind.Local).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 414, DateTimeKind.Local).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 414, DateTimeKind.Local).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 414, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 414, DateTimeKind.Local).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 414, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 414, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 414, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 449, DateTimeKind.Local).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 449, DateTimeKind.Local).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 425, DateTimeKind.Local).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 425, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 425, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 435, DateTimeKind.Local).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 438, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 438, DateTimeKind.Local).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 429, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 429, DateTimeKind.Local).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 429, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 429, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 429, DateTimeKind.Local).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 429, DateTimeKind.Local).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 429, DateTimeKind.Local).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 429, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 17, 20, 23, 429, DateTimeKind.Local).AddTicks(5374));
        }
    }
}
