using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class TransactionFee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TransactionFee",
                table: "Transactions",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransactionFee",
                table: "Transactions");

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 569, DateTimeKind.Local).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 569, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 569, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 569, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 630, DateTimeKind.Local).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 630, DateTimeKind.Local).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 636, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 636, DateTimeKind.Local).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 579, DateTimeKind.Local).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 579, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 579, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 579, DateTimeKind.Local).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 579, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5797));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5836));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5936));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6024));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6169));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6227));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6335));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6340));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6368));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6477));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 586, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3445));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3499));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3595));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3645));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3679));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 573, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 616, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 644, DateTimeKind.Local).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 644, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 644, DateTimeKind.Local).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 598, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 598, DateTimeKind.Local).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 598, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 598, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 598, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 598, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 601, DateTimeKind.Local).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 601, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 601, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 601, DateTimeKind.Local).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 613, DateTimeKind.Local).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 612, DateTimeKind.Local).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 612, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 612, DateTimeKind.Local).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 612, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 596, DateTimeKind.Local).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 596, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 596, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 575, DateTimeKind.Local).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 575, DateTimeKind.Local).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 583, DateTimeKind.Local).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 583, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 639, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 639, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 639, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 639, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 642, DateTimeKind.Local).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 642, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 642, DateTimeKind.Local).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 642, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 642, DateTimeKind.Local).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 642, DateTimeKind.Local).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 642, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 642, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 642, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 642, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 642, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 642, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 641, DateTimeKind.Local).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 641, DateTimeKind.Local).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 605, DateTimeKind.Local).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 605, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 605, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 605, DateTimeKind.Local).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 605, DateTimeKind.Local).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 605, DateTimeKind.Local).AddTicks(1583));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 605, DateTimeKind.Local).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 605, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 608, DateTimeKind.Local).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 608, DateTimeKind.Local).AddTicks(327));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 608, DateTimeKind.Local).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 608, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 608, DateTimeKind.Local).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 608, DateTimeKind.Local).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 608, DateTimeKind.Local).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 608, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 608, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 608, DateTimeKind.Local).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 608, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 608, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 608, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 608, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 608, DateTimeKind.Local).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 608, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 608, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 608, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 608, DateTimeKind.Local).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9994,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 608, DateTimeKind.Local).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9995,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 608, DateTimeKind.Local).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9996,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 608, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9997,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 608, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 608, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 608, DateTimeKind.Local).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 564, DateTimeKind.Local).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 564, DateTimeKind.Local).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 564, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 564, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 564, DateTimeKind.Local).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 560, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 560, DateTimeKind.Local).AddTicks(9895));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 560, DateTimeKind.Local).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 560, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 560, DateTimeKind.Local).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 560, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 560, DateTimeKind.Local).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 560, DateTimeKind.Local).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 560, DateTimeKind.Local).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 560, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 560, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 560, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 560, DateTimeKind.Local).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 560, DateTimeKind.Local).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 560, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 560, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 560, DateTimeKind.Local).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 560, DateTimeKind.Local).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 560, DateTimeKind.Local).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(19));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(45));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(59));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(69));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(111));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(169));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(179));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(191));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(199));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(205));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(262));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(279));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(287));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(291));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(327));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(331));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(351));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 590, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 590, DateTimeKind.Local).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 590, DateTimeKind.Local).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 590, DateTimeKind.Local).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 633, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 633, DateTimeKind.Local).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 633, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 580, DateTimeKind.Local).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 580, DateTimeKind.Local).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 580, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 580, DateTimeKind.Local).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 580, DateTimeKind.Local).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 580, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 580, DateTimeKind.Local).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 617, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 617, DateTimeKind.Local).AddTicks(2907));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 617, DateTimeKind.Local).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 617, DateTimeKind.Local).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 617, DateTimeKind.Local).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 617, DateTimeKind.Local).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 617, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 617, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 617, DateTimeKind.Local).AddTicks(2932));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 617, DateTimeKind.Local).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 617, DateTimeKind.Local).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 617, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 617, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 617, DateTimeKind.Local).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 617, DateTimeKind.Local).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 617, DateTimeKind.Local).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 617, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 617, DateTimeKind.Local).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 617, DateTimeKind.Local).AddTicks(2951));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 617, DateTimeKind.Local).AddTicks(2952));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 617, DateTimeKind.Local).AddTicks(2954));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 617, DateTimeKind.Local).AddTicks(2955));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 617, DateTimeKind.Local).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 617, DateTimeKind.Local).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 617, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6647));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 561, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 552, DateTimeKind.Local).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 555, DateTimeKind.Local).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 555, DateTimeKind.Local).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 623, DateTimeKind.Local).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 624, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 624, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 624, DateTimeKind.Local).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 646, DateTimeKind.Local).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 646, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 646, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 646, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 646, DateTimeKind.Local).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 646, DateTimeKind.Local).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 627, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 627, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 627, DateTimeKind.Local).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 627, DateTimeKind.Local).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 627, DateTimeKind.Local).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 627, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 566, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 567, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 567, DateTimeKind.Local).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 567, DateTimeKind.Local).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 567, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 567, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 567, DateTimeKind.Local).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 567, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 601, DateTimeKind.Local).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 601, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 578, DateTimeKind.Local).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 578, DateTimeKind.Local).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 578, DateTimeKind.Local).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 591, DateTimeKind.Local).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 593, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 593, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 582, DateTimeKind.Local).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 582, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 582, DateTimeKind.Local).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 582, DateTimeKind.Local).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 582, DateTimeKind.Local).AddTicks(7619));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 582, DateTimeKind.Local).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 582, DateTimeKind.Local).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 582, DateTimeKind.Local).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 12, 15, 52, 4, 582, DateTimeKind.Local).AddTicks(7646));
        }
    }
}
