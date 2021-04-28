using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class NewProductColumnOnClientDeduction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientDeductions_InvoiceStatuses_InvoiceStatusID",
                table: "ClientDeductions");

            migrationBuilder.AlterColumn<int>(
                name: "InvoiceStatusID",
                table: "ClientDeductions",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "ClientDeductions",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 516, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 516, DateTimeKind.Local).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 516, DateTimeKind.Local).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 516, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 581, DateTimeKind.Local).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 581, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 588, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 588, DateTimeKind.Local).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 527, DateTimeKind.Local).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 527, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 527, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 527, DateTimeKind.Local).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 527, DateTimeKind.Local).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9065));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9168));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9204));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9215));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 535, DateTimeKind.Local).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 519, DateTimeKind.Local).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 529, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 529, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 529, DateTimeKind.Local).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 529, DateTimeKind.Local).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(2836));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(2853));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(2908));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(2958));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(3111));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(3117));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 567, DateTimeKind.Local).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 547, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 547, DateTimeKind.Local).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 547, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 547, DateTimeKind.Local).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 547, DateTimeKind.Local).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 547, DateTimeKind.Local).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 550, DateTimeKind.Local).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 550, DateTimeKind.Local).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 550, DateTimeKind.Local).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 550, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 562, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 562, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 562, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 562, DateTimeKind.Local).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 562, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 544, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 544, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 544, DateTimeKind.Local).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 523, DateTimeKind.Local).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 523, DateTimeKind.Local).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 531, DateTimeKind.Local).AddTicks(7301));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 531, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 591, DateTimeKind.Local).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 591, DateTimeKind.Local).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 591, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.InsertData(
                table: "InvoiceStatuses",
                columns: new[] { "InvoiceStatusID", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[] { 4, "SuperUser", new DateTime(2021, 4, 28, 22, 39, 49, 591, DateTimeKind.Local).AddTicks(4025), "Unknown" });

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 553, DateTimeKind.Local).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 553, DateTimeKind.Local).AddTicks(1362));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 553, DateTimeKind.Local).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 553, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 553, DateTimeKind.Local).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 553, DateTimeKind.Local).AddTicks(1408));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 553, DateTimeKind.Local).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 555, DateTimeKind.Local).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 555, DateTimeKind.Local).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 555, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                columns: new[] { "ActionName", "LastChangedDate" },
                values: new object[] { "BulkInvoices", new DateTime(2021, 4, 28, 22, 39, 49, 555, DateTimeKind.Local).AddTicks(3864) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                columns: new[] { "ActionName", "LastChangedDate" },
                values: new object[] { "Invoices", new DateTime(2021, 4, 28, 22, 39, 49, 555, DateTimeKind.Local).AddTicks(3867) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 555, DateTimeKind.Local).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 555, DateTimeKind.Local).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 555, DateTimeKind.Local).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 555, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 555, DateTimeKind.Local).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 555, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 555, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 555, DateTimeKind.Local).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 555, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 555, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 555, DateTimeKind.Local).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 555, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 555, DateTimeKind.Local).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 555, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 555, DateTimeKind.Local).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 555, DateTimeKind.Local).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 555, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 507, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 507, DateTimeKind.Local).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 507, DateTimeKind.Local).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 507, DateTimeKind.Local).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 507, DateTimeKind.Local).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5296));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5877));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5915));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5945));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(6154));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 501, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 536, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 536, DateTimeKind.Local).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 536, DateTimeKind.Local).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 536, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 585, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 585, DateTimeKind.Local).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 585, DateTimeKind.Local).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 528, DateTimeKind.Local).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 528, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 528, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 528, DateTimeKind.Local).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 528, DateTimeKind.Local).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 528, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 528, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 568, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 568, DateTimeKind.Local).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 568, DateTimeKind.Local).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 568, DateTimeKind.Local).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 568, DateTimeKind.Local).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 568, DateTimeKind.Local).AddTicks(1654));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 568, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 568, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 568, DateTimeKind.Local).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 568, DateTimeKind.Local).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 568, DateTimeKind.Local).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 568, DateTimeKind.Local).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 568, DateTimeKind.Local).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 568, DateTimeKind.Local).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 568, DateTimeKind.Local).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 568, DateTimeKind.Local).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 568, DateTimeKind.Local).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 568, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 568, DateTimeKind.Local).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 568, DateTimeKind.Local).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 568, DateTimeKind.Local).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 568, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7575));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7619));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7792));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7834));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 502, DateTimeKind.Local).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 491, DateTimeKind.Local).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 493, DateTimeKind.Local).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 493, DateTimeKind.Local).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 574, DateTimeKind.Local).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 575, DateTimeKind.Local).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 530, DateTimeKind.Local).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 530, DateTimeKind.Local).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 530, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 530, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 530, DateTimeKind.Local).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 530, DateTimeKind.Local).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 530, DateTimeKind.Local).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 530, DateTimeKind.Local).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 530, DateTimeKind.Local).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 578, DateTimeKind.Local).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 578, DateTimeKind.Local).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 578, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 578, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 578, DateTimeKind.Local).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 578, DateTimeKind.Local).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 512, DateTimeKind.Local).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 512, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 512, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 512, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 512, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 512, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 512, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 512, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 551, DateTimeKind.Local).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 551, DateTimeKind.Local).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 526, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 526, DateTimeKind.Local).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 526, DateTimeKind.Local).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 537, DateTimeKind.Local).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 540, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 22, 39, 49, 540, DateTimeKind.Local).AddTicks(9523));

            migrationBuilder.CreateIndex(
                name: "IX_ClientDeductions_ProductID",
                table: "ClientDeductions",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientDeductions_InvoiceStatuses_InvoiceStatusID",
                table: "ClientDeductions",
                column: "InvoiceStatusID",
                principalTable: "InvoiceStatuses",
                principalColumn: "InvoiceStatusID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientDeductions_Products_ProductID",
                table: "ClientDeductions",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientDeductions_InvoiceStatuses_InvoiceStatusID",
                table: "ClientDeductions");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientDeductions_Products_ProductID",
                table: "ClientDeductions");

            migrationBuilder.DropIndex(
                name: "IX_ClientDeductions_ProductID",
                table: "ClientDeductions");

            migrationBuilder.DeleteData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "ClientDeductions");

            migrationBuilder.AlterColumn<int>(
                name: "InvoiceStatusID",
                table: "ClientDeductions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 744, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 744, DateTimeKind.Local).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 744, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 744, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 812, DateTimeKind.Local).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 812, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 818, DateTimeKind.Local).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 818, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 756, DateTimeKind.Local).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 756, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 756, DateTimeKind.Local).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 756, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 756, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3314));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3532));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3607));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3807));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3855));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 764, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 747, DateTimeKind.Local).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(582));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(962));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1098));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1154));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1165));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 748, DateTimeKind.Local).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 758, DateTimeKind.Local).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 758, DateTimeKind.Local).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 758, DateTimeKind.Local).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 758, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2097));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2555));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2634));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2784));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2806));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 800, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 775, DateTimeKind.Local).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 775, DateTimeKind.Local).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 775, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 775, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 775, DateTimeKind.Local).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 775, DateTimeKind.Local).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 778, DateTimeKind.Local).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 778, DateTimeKind.Local).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 778, DateTimeKind.Local).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 778, DateTimeKind.Local).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 790, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 789, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 789, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 789, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 789, DateTimeKind.Local).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 772, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 772, DateTimeKind.Local).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 772, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 751, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 751, DateTimeKind.Local).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 761, DateTimeKind.Local).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 761, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 821, DateTimeKind.Local).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 821, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 821, DateTimeKind.Local).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 780, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 780, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 780, DateTimeKind.Local).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 780, DateTimeKind.Local).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 780, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 780, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 780, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 783, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 783, DateTimeKind.Local).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 783, DateTimeKind.Local).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                columns: new[] { "ActionName", "LastChangedDate" },
                values: new object[] { "Schedule", new DateTime(2021, 4, 28, 20, 46, 10, 783, DateTimeKind.Local).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                columns: new[] { "ActionName", "LastChangedDate" },
                values: new object[] { "ScheduleReport", new DateTime(2021, 4, 28, 20, 46, 10, 783, DateTimeKind.Local).AddTicks(5796) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 783, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 783, DateTimeKind.Local).AddTicks(5813));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 783, DateTimeKind.Local).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 783, DateTimeKind.Local).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 783, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 783, DateTimeKind.Local).AddTicks(5836));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 783, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 783, DateTimeKind.Local).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 783, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 783, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 783, DateTimeKind.Local).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 783, DateTimeKind.Local).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 783, DateTimeKind.Local).AddTicks(5873));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 783, DateTimeKind.Local).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 783, DateTimeKind.Local).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 783, DateTimeKind.Local).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 783, DateTimeKind.Local).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 735, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 735, DateTimeKind.Local).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 735, DateTimeKind.Local).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 735, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 735, DateTimeKind.Local).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4977));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(4999));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5187));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5245));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 731, DateTimeKind.Local).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 765, DateTimeKind.Local).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 765, DateTimeKind.Local).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 765, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 765, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 815, DateTimeKind.Local).AddTicks(1807));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 815, DateTimeKind.Local).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 815, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 757, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 757, DateTimeKind.Local).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 757, DateTimeKind.Local).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 757, DateTimeKind.Local).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 757, DateTimeKind.Local).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 757, DateTimeKind.Local).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 757, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 801, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 801, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 801, DateTimeKind.Local).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 801, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 801, DateTimeKind.Local).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 801, DateTimeKind.Local).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 801, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 801, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 801, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 801, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 801, DateTimeKind.Local).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 801, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 801, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 801, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 801, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 801, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 801, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 801, DateTimeKind.Local).AddTicks(2361));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 801, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 801, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 801, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 801, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3789));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3791));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3853));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 732, DateTimeKind.Local).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 724, DateTimeKind.Local).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 725, DateTimeKind.Local).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 725, DateTimeKind.Local).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 807, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 807, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 760, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 760, DateTimeKind.Local).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 760, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 760, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 760, DateTimeKind.Local).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 760, DateTimeKind.Local).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 760, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 760, DateTimeKind.Local).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 760, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 810, DateTimeKind.Local).AddTicks(223));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 810, DateTimeKind.Local).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 810, DateTimeKind.Local).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 810, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 810, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 810, DateTimeKind.Local).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 740, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 740, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 740, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 740, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 740, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 740, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 740, DateTimeKind.Local).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 740, DateTimeKind.Local).AddTicks(5261));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 778, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 778, DateTimeKind.Local).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 754, DateTimeKind.Local).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 755, DateTimeKind.Local).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 755, DateTimeKind.Local).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 766, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 769, DateTimeKind.Local).AddTicks(7903));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 28, 20, 46, 10, 769, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.AddForeignKey(
                name: "FK_ClientDeductions_InvoiceStatuses_InvoiceStatusID",
                table: "ClientDeductions",
                column: "InvoiceStatusID",
                principalTable: "InvoiceStatuses",
                principalColumn: "InvoiceStatusID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
