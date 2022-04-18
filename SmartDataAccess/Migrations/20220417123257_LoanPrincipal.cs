using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class LoanPrincipal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Principal",
                table: "LoanFinances",
                type: "decimal(18, 0)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 144, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 144, DateTimeKind.Local).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 144, DateTimeKind.Local).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 144, DateTimeKind.Local).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "CalculationTypes",
                keyColumn: "CalculationTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 177, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "CalculationTypes",
                keyColumn: "CalculationTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 177, DateTimeKind.Local).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 163, DateTimeKind.Local).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 163, DateTimeKind.Local).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 165, DateTimeKind.Local).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 166, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 146, DateTimeKind.Local).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 146, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 146, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 146, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 146, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5218));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5227));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5245));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5273));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5278));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5309));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5516));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5776));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5813));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 149, DateTimeKind.Local).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4323));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4489));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 145, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 170, DateTimeKind.Local).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 170, DateTimeKind.Local).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 170, DateTimeKind.Local).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 153, DateTimeKind.Local).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 153, DateTimeKind.Local).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 153, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 153, DateTimeKind.Local).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 153, DateTimeKind.Local).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 153, DateTimeKind.Local).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 154, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 154, DateTimeKind.Local).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 154, DateTimeKind.Local).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 154, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 157, DateTimeKind.Local).AddTicks(7619));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 157, DateTimeKind.Local).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 157, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 157, DateTimeKind.Local).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 157, DateTimeKind.Local).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 152, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 152, DateTimeKind.Local).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 152, DateTimeKind.Local).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 178, DateTimeKind.Local).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 178, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 178, DateTimeKind.Local).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 178, DateTimeKind.Local).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 178, DateTimeKind.Local).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 178, DateTimeKind.Local).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 178, DateTimeKind.Local).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 178, DateTimeKind.Local).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 148, DateTimeKind.Local).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 148, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 167, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 167, DateTimeKind.Local).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 167, DateTimeKind.Local).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 167, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5797));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 169, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 168, DateTimeKind.Local).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 168, DateTimeKind.Local).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 168, DateTimeKind.Local).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 168, DateTimeKind.Local).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 168, DateTimeKind.Local).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 168, DateTimeKind.Local).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 168, DateTimeKind.Local).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "LoanStatus",
                keyColumn: "LoanStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 176, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "LoanStatus",
                keyColumn: "LoanStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 176, DateTimeKind.Local).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "LoanStatus",
                keyColumn: "LoanStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 176, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "LoanStatus",
                keyColumn: "LoanStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 176, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 155, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 155, DateTimeKind.Local).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 155, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 155, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 155, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 155, DateTimeKind.Local).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 155, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 155, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 155, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 155, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 155, DateTimeKind.Local).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 155, DateTimeKind.Local).AddTicks(5968));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 155, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 155, DateTimeKind.Local).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 155, DateTimeKind.Local).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 155, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9994,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 155, DateTimeKind.Local).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9995,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 155, DateTimeKind.Local).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9996,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 155, DateTimeKind.Local).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 142, DateTimeKind.Local).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 142, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 142, DateTimeKind.Local).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 142, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 142, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 175, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 175, DateTimeKind.Local).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 175, DateTimeKind.Local).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 175, DateTimeKind.Local).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 175, DateTimeKind.Local).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 175, DateTimeKind.Local).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7370), "Un Finalise Loan" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7373), "Add Loan Beneficiary" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7377), "Update Loan Beneficiary" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 136,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7380), "View Loan Beneficiary" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 137,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7383), "Delete Loan Beneficiary" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 138,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7387), "Update Product Computation" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 139,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7391), "View Product Computation" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 140,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7418), "Loan Upload Document" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 141,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7421), "Loan View Document" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 142,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7425), "Add Loan Note" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 143,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7428), "Update Loan Note" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 144,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7431), "View Loan Note" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 145,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7434), "Delete Loan Note" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 146,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7437), "Add Fiscal Year" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 147,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7441), "Update Fiscal Year" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 148,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7444), "View Fiscal Year" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionID", "Description", "IsActive", "IsDeleted", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[] { 149, null, true, false, "SuperUser", new DateTime(2022, 4, 17, 22, 32, 56, 140, DateTimeKind.Local).AddTicks(7447), "Delete Fiscal Year" });

            migrationBuilder.UpdateData(
                table: "PinCodeTypes",
                keyColumn: "PinCodeTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 172, DateTimeKind.Local).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "PinCodeTypes",
                keyColumn: "PinCodeTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 172, DateTimeKind.Local).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "PinCodeTypes",
                keyColumn: "PinCodeTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 172, DateTimeKind.Local).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 150, DateTimeKind.Local).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 150, DateTimeKind.Local).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 150, DateTimeKind.Local).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 150, DateTimeKind.Local).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "ProductComputations",
                keyColumn: "ProductComputationID",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastChangedDate" },
                values: new object[] { new DateTime(2022, 4, 17, 22, 32, 56, 179, DateTimeKind.Local).AddTicks(3948), new DateTime(2022, 4, 17, 22, 32, 56, 179, DateTimeKind.Local).AddTicks(4224) });

            migrationBuilder.UpdateData(
                table: "ProductComputations",
                keyColumn: "ProductComputationID",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastChangedDate" },
                values: new object[] { new DateTime(2022, 4, 17, 22, 32, 56, 179, DateTimeKind.Local).AddTicks(4464), new DateTime(2022, 4, 17, 22, 32, 56, 179, DateTimeKind.Local).AddTicks(4478) });

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 164, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 164, DateTimeKind.Local).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 164, DateTimeKind.Local).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 147, DateTimeKind.Local).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 147, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 147, DateTimeKind.Local).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 147, DateTimeKind.Local).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 147, DateTimeKind.Local).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 147, DateTimeKind.Local).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 147, DateTimeKind.Local).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 159, DateTimeKind.Local).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(608));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(647));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(652));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(656));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 137, DateTimeKind.Local).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 138, DateTimeKind.Local).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 138, DateTimeKind.Local).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 161, DateTimeKind.Local).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 161, DateTimeKind.Local).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 161, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 161, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 171, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 171, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 171, DateTimeKind.Local).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 171, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 171, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 171, DateTimeKind.Local).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 171, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 162, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 162, DateTimeKind.Local).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 162, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 162, DateTimeKind.Local).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 162, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 162, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 143, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 143, DateTimeKind.Local).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 143, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 143, DateTimeKind.Local).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 143, DateTimeKind.Local).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 143, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 143, DateTimeKind.Local).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 143, DateTimeKind.Local).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 154, DateTimeKind.Local).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 154, DateTimeKind.Local).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 146, DateTimeKind.Local).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 146, DateTimeKind.Local).AddTicks(4879));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 146, DateTimeKind.Local).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 150, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 151, DateTimeKind.Local).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 151, DateTimeKind.Local).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 148, DateTimeKind.Local).AddTicks(1356));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 148, DateTimeKind.Local).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 148, DateTimeKind.Local).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 148, DateTimeKind.Local).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 148, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 148, DateTimeKind.Local).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 148, DateTimeKind.Local).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 148, DateTimeKind.Local).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 32, 56, 148, DateTimeKind.Local).AddTicks(1554));

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "RolePermissionID", "LastChangedBy", "LastChangedDate", "PermissionID", "RoleID" },
                values: new object[] { 149, "SuperUser", new DateTime(2022, 4, 17, 22, 32, 56, 141, DateTimeKind.Local).AddTicks(741), 149, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 149);

            migrationBuilder.DropColumn(
                name: "Principal",
                table: "LoanFinances");

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 632, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 632, DateTimeKind.Local).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 632, DateTimeKind.Local).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 632, DateTimeKind.Local).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "CalculationTypes",
                keyColumn: "CalculationTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 682, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "CalculationTypes",
                keyColumn: "CalculationTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 682, DateTimeKind.Local).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 665, DateTimeKind.Local).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 665, DateTimeKind.Local).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 667, DateTimeKind.Local).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 667, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 635, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 635, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 635, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 635, DateTimeKind.Local).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 635, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8495));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 639, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5299));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5516));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 633, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 656, DateTimeKind.Local).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 674, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 674, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 674, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 646, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 646, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 646, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 646, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 646, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 646, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 647, DateTimeKind.Local).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 647, DateTimeKind.Local).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 647, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 647, DateTimeKind.Local).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 651, DateTimeKind.Local).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 651, DateTimeKind.Local).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 651, DateTimeKind.Local).AddTicks(2213));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 651, DateTimeKind.Local).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 651, DateTimeKind.Local).AddTicks(2226));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 644, DateTimeKind.Local).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 644, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 644, DateTimeKind.Local).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 684, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 684, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 684, DateTimeKind.Local).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 684, DateTimeKind.Local).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 684, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 684, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 684, DateTimeKind.Local).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 684, DateTimeKind.Local).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 637, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 637, DateTimeKind.Local).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 669, DateTimeKind.Local).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 669, DateTimeKind.Local).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 669, DateTimeKind.Local).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 669, DateTimeKind.Local).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5306));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 673, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 670, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 670, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 670, DateTimeKind.Local).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 670, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 670, DateTimeKind.Local).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 670, DateTimeKind.Local).AddTicks(9962));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 670, DateTimeKind.Local).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "LoanStatus",
                keyColumn: "LoanStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 681, DateTimeKind.Local).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "LoanStatus",
                keyColumn: "LoanStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 681, DateTimeKind.Local).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "LoanStatus",
                keyColumn: "LoanStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 681, DateTimeKind.Local).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "LoanStatus",
                keyColumn: "LoanStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 681, DateTimeKind.Local).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 648, DateTimeKind.Local).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 648, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 648, DateTimeKind.Local).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 648, DateTimeKind.Local).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 648, DateTimeKind.Local).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 648, DateTimeKind.Local).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 648, DateTimeKind.Local).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 648, DateTimeKind.Local).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 648, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 648, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 648, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 648, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 648, DateTimeKind.Local).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 648, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 648, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 648, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9994,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 648, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9995,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 648, DateTimeKind.Local).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9996,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 648, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 629, DateTimeKind.Local).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 629, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 629, DateTimeKind.Local).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 629, DateTimeKind.Local).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 629, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 680, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 680, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 680, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 680, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 680, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 680, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9202));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9533), "Add Loan Beneficiary" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9537), "Update Loan Beneficiary" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9541), "View Loan Beneficiary" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 136,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9545), "Delete Loan Beneficiary" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 137,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9549), "Update Product Computation" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 138,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9553), "View Product Computation" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 139,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9557), "Loan Upload Document" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 140,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9561), "Loan View Document" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 141,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9564), "Add Loan Note" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 142,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9568), "Update Loan Note" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 143,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9572), "View Loan Note" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 144,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9575), "Delete Loan Note" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 145,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9580), "Add Fiscal Year" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 146,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9584), "Update Fiscal Year" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 147,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9588), "View Fiscal Year" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 148,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 11, 21, 17, 33, 627, DateTimeKind.Local).AddTicks(9591), "Delete Fiscal Year" });

            migrationBuilder.UpdateData(
                table: "PinCodeTypes",
                keyColumn: "PinCodeTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 677, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "PinCodeTypes",
                keyColumn: "PinCodeTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 677, DateTimeKind.Local).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "PinCodeTypes",
                keyColumn: "PinCodeTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 677, DateTimeKind.Local).AddTicks(1223));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 641, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 641, DateTimeKind.Local).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 641, DateTimeKind.Local).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 641, DateTimeKind.Local).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "ProductComputations",
                keyColumn: "ProductComputationID",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastChangedDate" },
                values: new object[] { new DateTime(2022, 4, 11, 21, 17, 33, 685, DateTimeKind.Local).AddTicks(8001), new DateTime(2022, 4, 11, 21, 17, 33, 685, DateTimeKind.Local).AddTicks(8344) });

            migrationBuilder.UpdateData(
                table: "ProductComputations",
                keyColumn: "ProductComputationID",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastChangedDate" },
                values: new object[] { new DateTime(2022, 4, 11, 21, 17, 33, 685, DateTimeKind.Local).AddTicks(8773), new DateTime(2022, 4, 11, 21, 17, 33, 685, DateTimeKind.Local).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 666, DateTimeKind.Local).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 666, DateTimeKind.Local).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 666, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 635, DateTimeKind.Local).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 635, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 635, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 635, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 635, DateTimeKind.Local).AddTicks(5261));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 635, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 635, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 657, DateTimeKind.Local).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 657, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 657, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 657, DateTimeKind.Local).AddTicks(948));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 657, DateTimeKind.Local).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 657, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 657, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 657, DateTimeKind.Local).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 657, DateTimeKind.Local).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 657, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3457));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3465));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3469));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3475));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3499));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3532));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 628, DateTimeKind.Local).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 621, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 625, DateTimeKind.Local).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 625, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 662, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 662, DateTimeKind.Local).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 662, DateTimeKind.Local).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 662, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 675, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 675, DateTimeKind.Local).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 675, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 675, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 675, DateTimeKind.Local).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 675, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 675, DateTimeKind.Local).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 663, DateTimeKind.Local).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 663, DateTimeKind.Local).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 663, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 663, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 663, DateTimeKind.Local).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 663, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 630, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 631, DateTimeKind.Local).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 631, DateTimeKind.Local).AddTicks(341));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 631, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 631, DateTimeKind.Local).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 631, DateTimeKind.Local).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 631, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 631, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 647, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 647, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 634, DateTimeKind.Local).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 634, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 634, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 642, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 642, DateTimeKind.Local).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 642, DateTimeKind.Local).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 636, DateTimeKind.Local).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 636, DateTimeKind.Local).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 636, DateTimeKind.Local).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 636, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 636, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 636, DateTimeKind.Local).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 636, DateTimeKind.Local).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 636, DateTimeKind.Local).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 11, 21, 17, 33, 636, DateTimeKind.Local).AddTicks(9278));
        }
    }
}
