using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class AlterClientDeductionFee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AdditionalDeductionPercentage",
                table: "ClientDeductions",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalDeductionPercentage",
                table: "ClientDeductions",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 911, DateTimeKind.Local).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 911, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 911, DateTimeKind.Local).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 911, DateTimeKind.Local).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 921, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 921, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 921, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 921, DateTimeKind.Local).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 921, DateTimeKind.Local).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(789));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(955));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(959));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(962));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1032));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1081));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1093));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1105));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1142));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1146));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1157));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1195));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1279));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1318));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1326));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1394));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1466));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1584));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1588));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1611));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 928, DateTimeKind.Local).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4319));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4842));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4879));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 914, DateTimeKind.Local).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 922, DateTimeKind.Local).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 922, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 922, DateTimeKind.Local).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 922, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 954, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 937, DateTimeKind.Local).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 937, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 937, DateTimeKind.Local).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 937, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 937, DateTimeKind.Local).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 937, DateTimeKind.Local).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 940, DateTimeKind.Local).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 940, DateTimeKind.Local).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 940, DateTimeKind.Local).AddTicks(3666));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 940, DateTimeKind.Local).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 950, DateTimeKind.Local).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 950, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 950, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 950, DateTimeKind.Local).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 935, DateTimeKind.Local).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 935, DateTimeKind.Local).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 935, DateTimeKind.Local).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 917, DateTimeKind.Local).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 917, DateTimeKind.Local).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 925, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 925, DateTimeKind.Local).AddTicks(916));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 942, DateTimeKind.Local).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 942, DateTimeKind.Local).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                columns: new[] { "DisplayName", "LastChangedDate" },
                values: new object[] { "Product Packaging", new DateTime(2020, 10, 8, 19, 24, 50, 942, DateTimeKind.Local).AddTicks(6231) });

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                columns: new[] { "DisplayName", "LastChangedDate" },
                values: new object[] { "System Settings", new DateTime(2020, 10, 8, 19, 24, 50, 942, DateTimeKind.Local).AddTicks(6244) });

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                columns: new[] { "DisplayName", "LastChangedDate" },
                values: new object[] { "Administration Settings", new DateTime(2020, 10, 8, 19, 24, 50, 942, DateTimeKind.Local).AddTicks(6237) });

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 942, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 942, DateTimeKind.Local).AddTicks(6253));

            migrationBuilder.InsertData(
                table: "MenuGroups",
                columns: new[] { "MenuGroupID", "CSSClass", "Description", "DisplayName", "IsActive", "IsActiveMenu", "LastChangedBy", "LastChangedDate", "OrderNo" },
                values: new object[,]
                {
                    { 6, "fa fa-money", null, "Transactions", true, false, "SuperUser", new DateTime(2020, 10, 8, 19, 24, 50, 942, DateTimeKind.Local).AddTicks(6271), 9 },
                    { 7, "fa fa-product-hunt", null, "Schedules", true, false, "SuperUser", new DateTime(2020, 10, 8, 19, 24, 50, 942, DateTimeKind.Local).AddTicks(6265), 8 }
                });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 944, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 944, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 944, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 944, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 944, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 944, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 944, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 944, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 944, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 944, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 944, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 944, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 944, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 944, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 944, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 944, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 944, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 944, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 944, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 905, DateTimeKind.Local).AddTicks(191));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 905, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 905, DateTimeKind.Local).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 905, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 905, DateTimeKind.Local).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3743));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3853));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4269));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 901, DateTimeKind.Local).AddTicks(4319));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 929, DateTimeKind.Local).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 929, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 929, DateTimeKind.Local).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 929, DateTimeKind.Local).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 921, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 921, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 921, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 921, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 921, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 955, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 955, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 955, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 955, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 955, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 955, DateTimeKind.Local).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 955, DateTimeKind.Local).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 955, DateTimeKind.Local).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 955, DateTimeKind.Local).AddTicks(5218));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 955, DateTimeKind.Local).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 955, DateTimeKind.Local).AddTicks(5223));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 955, DateTimeKind.Local).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 955, DateTimeKind.Local).AddTicks(5227));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 955, DateTimeKind.Local).AddTicks(5229));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 955, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 955, DateTimeKind.Local).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 955, DateTimeKind.Local).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 955, DateTimeKind.Local).AddTicks(5238));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 955, DateTimeKind.Local).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 955, DateTimeKind.Local).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 955, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1411));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1425));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1471));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 902, DateTimeKind.Local).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 894, DateTimeKind.Local).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 896, DateTimeKind.Local).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 896, DateTimeKind.Local).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 924, DateTimeKind.Local).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 924, DateTimeKind.Local).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 924, DateTimeKind.Local).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 924, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 924, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 924, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 924, DateTimeKind.Local).AddTicks(2716));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 924, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 924, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 908, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 908, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 908, DateTimeKind.Local).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 908, DateTimeKind.Local).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 908, DateTimeKind.Local).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 908, DateTimeKind.Local).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 908, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 908, DateTimeKind.Local).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 940, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 940, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 919, DateTimeKind.Local).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 920, DateTimeKind.Local).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 920, DateTimeKind.Local).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 929, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 932, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 19, 24, 50, 932, DateTimeKind.Local).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                columns: new[] { "LastChangedDate", "MenuGroupID" },
                values: new object[] { new DateTime(2020, 10, 8, 19, 24, 50, 944, DateTimeKind.Local).AddTicks(8743), 6 });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 21,
                columns: new[] { "DisplayName", "LastChangedDate", "MenuGroupID" },
                values: new object[] { "Generate  Schedule", new DateTime(2020, 10, 8, 19, 24, 50, 944, DateTimeKind.Local).AddTicks(8828), 7 });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuID", "ActionName", "CSSClass", "ControllerName", "DisplayName", "IsActive", "LastChangedBy", "LastChangedDate", "MenuGroupID", "OrderNo" },
                values: new object[] { 22, "ScheduleReporting", "fa fa-file", "Transactions", "Retrive  Schedule", true, "SuperUser", new DateTime(2020, 10, 8, 19, 24, 50, 944, DateTimeKind.Local).AddTicks(8833), 7, 22 });

            migrationBuilder.InsertData(
                table: "RoleMenus",
                columns: new[] { "RoleMenuID", "LastChangedBy", "LastChangedDate", "MenuID", "RoleID" },
                values: new object[] { 22, "SuperUser", new DateTime(2020, 10, 8, 19, 24, 50, 955, DateTimeKind.Local).AddTicks(5246), 22, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "AdditionalDeductionPercentage",
                table: "ClientDeductions");

            migrationBuilder.DropColumn(
                name: "TotalDeductionPercentage",
                table: "ClientDeductions");

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
                columns: new[] { "DisplayName", "LastChangedDate" },
                values: new object[] { "Accounting", new DateTime(2020, 10, 8, 17, 47, 46, 556, DateTimeKind.Local).AddTicks(644) });

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                columns: new[] { "DisplayName", "LastChangedDate" },
                values: new object[] { "Settings", new DateTime(2020, 10, 8, 17, 47, 46, 556, DateTimeKind.Local).AddTicks(654) });

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                columns: new[] { "DisplayName", "LastChangedDate" },
                values: new object[] { "Administration", new DateTime(2020, 10, 8, 17, 47, 46, 556, DateTimeKind.Local).AddTicks(649) });

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

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuID", "ActionName", "CSSClass", "ControllerName", "DisplayName", "IsActive", "LastChangedBy", "LastChangedDate", "MenuGroupID", "OrderNo" },
                values: new object[,]
                {
                    { 2, "Transactions", "fa fa-money", "Transactions", "Transactions", true, "SuperUser", new DateTime(2020, 10, 8, 17, 47, 46, 557, DateTimeKind.Local).AddTicks(9982), 3, 2 },
                    { 21, "Schedule", "fa fa-gear", "Transactions", "Run  Schedule", true, "SuperUser", new DateTime(2020, 10, 8, 17, 47, 46, 558, DateTimeKind.Local).AddTicks(91), 3, 21 }
                });

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

            migrationBuilder.InsertData(
                table: "RoleMenus",
                columns: new[] { "RoleMenuID", "LastChangedBy", "LastChangedDate", "MenuID", "RoleID" },
                values: new object[] { 21, "SuperUser", new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(9810), 21, 1 });

            migrationBuilder.InsertData(
                table: "RoleMenus",
                columns: new[] { "RoleMenuID", "LastChangedBy", "LastChangedDate", "MenuID", "RoleID" },
                values: new object[] { 2, "SuperUser", new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(9771), 2, 1 });
        }
    }
}
