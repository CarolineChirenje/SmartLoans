using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class TransactionReversalPaymentID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReversalPaymentID",
                table: "Transactions",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "IncreamentPercentage",
                table: "ClientProducts",
                type: "decimal(18,4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DeductionPercentage",
                table: "ClientProducts",
                type: "decimal(18,4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 935, DateTimeKind.Local).AddTicks(192));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 935, DateTimeKind.Local).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 935, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 935, DateTimeKind.Local).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 994, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 994, DateTimeKind.Local).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 943, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 943, DateTimeKind.Local).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 943, DateTimeKind.Local).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 943, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 943, DateTimeKind.Local).AddTicks(1662));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5278));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5287));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5598));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5634));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5813));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5873));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5885));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5943));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 949, DateTimeKind.Local).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5283));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5287));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5618));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 937, DateTimeKind.Local).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 944, DateTimeKind.Local).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 944, DateTimeKind.Local).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 944, DateTimeKind.Local).AddTicks(6109));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 944, DateTimeKind.Local).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(4999));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 980, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 959, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 959, DateTimeKind.Local).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 959, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 959, DateTimeKind.Local).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 959, DateTimeKind.Local).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 959, DateTimeKind.Local).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 962, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 962, DateTimeKind.Local).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 962, DateTimeKind.Local).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 962, DateTimeKind.Local).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 972, DateTimeKind.Local).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 972, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 972, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 972, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 972, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 956, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 956, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 956, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 939, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 939, DateTimeKind.Local).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 946, DateTimeKind.Local).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 946, DateTimeKind.Local).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 965, DateTimeKind.Local).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 965, DateTimeKind.Local).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 965, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 965, DateTimeKind.Local).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 965, DateTimeKind.Local).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 965, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 965, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 967, DateTimeKind.Local).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 967, DateTimeKind.Local).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 967, DateTimeKind.Local).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 967, DateTimeKind.Local).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 967, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 967, DateTimeKind.Local).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 967, DateTimeKind.Local).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 967, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 967, DateTimeKind.Local).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 967, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 967, DateTimeKind.Local).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 967, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 967, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 967, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 967, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 967, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 967, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 967, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 967, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 967, DateTimeKind.Local).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 967, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 967, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 929, DateTimeKind.Local).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 929, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 929, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 929, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 929, DateTimeKind.Local).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(7834));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 926, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 950, DateTimeKind.Local).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 950, DateTimeKind.Local).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 950, DateTimeKind.Local).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 950, DateTimeKind.Local).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 997, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 997, DateTimeKind.Local).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 997, DateTimeKind.Local).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 943, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 943, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 943, DateTimeKind.Local).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 943, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 943, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 943, DateTimeKind.Local).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 943, DateTimeKind.Local).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 981, DateTimeKind.Local).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 981, DateTimeKind.Local).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 981, DateTimeKind.Local).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 981, DateTimeKind.Local).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 981, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 981, DateTimeKind.Local).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 981, DateTimeKind.Local).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 981, DateTimeKind.Local).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 981, DateTimeKind.Local).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 981, DateTimeKind.Local).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 981, DateTimeKind.Local).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 981, DateTimeKind.Local).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 981, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 981, DateTimeKind.Local).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 981, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 981, DateTimeKind.Local).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 981, DateTimeKind.Local).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 981, DateTimeKind.Local).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 981, DateTimeKind.Local).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 981, DateTimeKind.Local).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 981, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 981, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4715));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4842));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4878));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 927, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 921, DateTimeKind.Local).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 922, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 922, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 987, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 987, DateTimeKind.Local).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 945, DateTimeKind.Local).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 945, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 945, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 945, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 945, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 945, DateTimeKind.Local).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 945, DateTimeKind.Local).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 945, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 945, DateTimeKind.Local).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 990, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 990, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 990, DateTimeKind.Local).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 990, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 990, DateTimeKind.Local).AddTicks(9615));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 990, DateTimeKind.Local).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 932, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 932, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 932, DateTimeKind.Local).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 932, DateTimeKind.Local).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 932, DateTimeKind.Local).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 932, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 932, DateTimeKind.Local).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 932, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 963, DateTimeKind.Local).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 963, DateTimeKind.Local).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 942, DateTimeKind.Local).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 942, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 942, DateTimeKind.Local).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 951, DateTimeKind.Local).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 954, DateTimeKind.Local).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 2, 11, 9, 954, DateTimeKind.Local).AddTicks(1163));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReversalPaymentID",
                table: "Transactions");

            migrationBuilder.AlterColumn<decimal>(
                name: "IncreamentPercentage",
                table: "ClientProducts",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DeductionPercentage",
                table: "ClientProducts",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 630, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 630, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 630, DateTimeKind.Local).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 630, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 688, DateTimeKind.Local).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 688, DateTimeKind.Local).AddTicks(1792));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 641, DateTimeKind.Local).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 641, DateTimeKind.Local).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 641, DateTimeKind.Local).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 641, DateTimeKind.Local).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 641, DateTimeKind.Local).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9654));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9725));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9776));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9882));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9895));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9903));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9962));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 647, DateTimeKind.Local).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(22));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(26));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(45));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(53));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(112));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(141));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(178));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(194));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(204));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(264));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(322));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(329));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(341));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(364));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 648, DateTimeKind.Local).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3113));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3117));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3122));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3126));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3137));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3175));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3182));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3205));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3314));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3446));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3474));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3532));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3607));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3666));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 635, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 643, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 643, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 643, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 643, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(1805));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(1841));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(1814));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(1940));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(1946));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(1958));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(1821));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(2057));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(2158));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 657, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 657, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 657, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 657, DateTimeKind.Local).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 657, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 657, DateTimeKind.Local).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 660, DateTimeKind.Local).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 660, DateTimeKind.Local).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 660, DateTimeKind.Local).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 660, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 671, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 670, DateTimeKind.Local).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 670, DateTimeKind.Local).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 670, DateTimeKind.Local).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 670, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 655, DateTimeKind.Local).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 655, DateTimeKind.Local).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 655, DateTimeKind.Local).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 638, DateTimeKind.Local).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 638, DateTimeKind.Local).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 645, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 645, DateTimeKind.Local).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 661, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 661, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 661, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 661, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 661, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 661, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 661, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 664, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 664, DateTimeKind.Local).AddTicks(1151));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 664, DateTimeKind.Local).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 664, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 664, DateTimeKind.Local).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 664, DateTimeKind.Local).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 664, DateTimeKind.Local).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 664, DateTimeKind.Local).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 664, DateTimeKind.Local).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 664, DateTimeKind.Local).AddTicks(1204));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 664, DateTimeKind.Local).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 664, DateTimeKind.Local).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 664, DateTimeKind.Local).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 664, DateTimeKind.Local).AddTicks(1223));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 664, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 664, DateTimeKind.Local).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 664, DateTimeKind.Local).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 664, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 664, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 664, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 664, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 664, DateTimeKind.Local).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 626, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 626, DateTimeKind.Local).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 626, DateTimeKind.Local).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 626, DateTimeKind.Local).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 626, DateTimeKind.Local).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 622, DateTimeKind.Local).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(948));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1154));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1162));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1223));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1248));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1252));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1282));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1298));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1318));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 649, DateTimeKind.Local).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 649, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 649, DateTimeKind.Local).AddTicks(1647));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 649, DateTimeKind.Local).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 690, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 690, DateTimeKind.Local).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 690, DateTimeKind.Local).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 642, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 642, DateTimeKind.Local).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 642, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 642, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 642, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 642, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 642, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 677, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 623, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 617, DateTimeKind.Local).AddTicks(2856));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 618, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 618, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 683, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 683, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 644, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 644, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 644, DateTimeKind.Local).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 644, DateTimeKind.Local).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 644, DateTimeKind.Local).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 644, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 644, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 644, DateTimeKind.Local).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 644, DateTimeKind.Local).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 685, DateTimeKind.Local).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 685, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 685, DateTimeKind.Local).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 685, DateTimeKind.Local).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 685, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 685, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 628, DateTimeKind.Local).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 628, DateTimeKind.Local).AddTicks(7073));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 628, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 628, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 628, DateTimeKind.Local).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 628, DateTimeKind.Local).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 628, DateTimeKind.Local).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 628, DateTimeKind.Local).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 660, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 660, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 640, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 640, DateTimeKind.Local).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 640, DateTimeKind.Local).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 649, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 652, DateTimeKind.Local).AddTicks(9709));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 22, 0, 39, 38, 652, DateTimeKind.Local).AddTicks(9980));
        }
    }
}
