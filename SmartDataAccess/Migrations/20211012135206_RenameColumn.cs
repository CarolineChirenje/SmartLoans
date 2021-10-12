using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class RenameColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransactionalLevy",
                table: "Products");

            migrationBuilder.AddColumn<decimal>(
                name: "TransactionalFee",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransactionalFee",
                table: "Products");

            migrationBuilder.AddColumn<decimal>(
                name: "TransactionalLevy",
                table: "Products",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 192, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 192, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 192, DateTimeKind.Local).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 192, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 267, DateTimeKind.Local).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 267, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 273, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 273, DateTimeKind.Local).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 205, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 205, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 205, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 205, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 205, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3807));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3853));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4482));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4531));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8113));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7792));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 284, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 285, DateTimeKind.Local).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 285, DateTimeKind.Local).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 229, DateTimeKind.Local).AddTicks(3137));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 229, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 229, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 229, DateTimeKind.Local).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 229, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 229, DateTimeKind.Local).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 232, DateTimeKind.Local).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 233, DateTimeKind.Local).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 233, DateTimeKind.Local).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 233, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 247, DateTimeKind.Local).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 246, DateTimeKind.Local).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 246, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 246, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 246, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 225, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 225, DateTimeKind.Local).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 225, DateTimeKind.Local).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 200, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 200, DateTimeKind.Local).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 210, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 210, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 276, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 276, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 276, DateTimeKind.Local).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 276, DateTimeKind.Local).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 282, DateTimeKind.Local).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 282, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 282, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 282, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 282, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 282, DateTimeKind.Local).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 282, DateTimeKind.Local).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 282, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 282, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 282, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 282, DateTimeKind.Local).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 282, DateTimeKind.Local).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 280, DateTimeKind.Local).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 280, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 236, DateTimeKind.Local).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 236, DateTimeKind.Local).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 236, DateTimeKind.Local).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 236, DateTimeKind.Local).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 236, DateTimeKind.Local).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 236, DateTimeKind.Local).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 236, DateTimeKind.Local).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 236, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9994,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9995,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9996,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9997,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 186, DateTimeKind.Local).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 186, DateTimeKind.Local).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 186, DateTimeKind.Local).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 186, DateTimeKind.Local).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 186, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1394));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1398));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1408));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1422));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1581));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1631));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1657));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1662));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1691));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1835));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1927));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1936));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1940));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1945));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1958));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1992));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 217, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 217, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 217, DateTimeKind.Local).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 217, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 270, DateTimeKind.Local).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 270, DateTimeKind.Local).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 270, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 206, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 206, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 206, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 206, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 206, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 206, DateTimeKind.Local).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 206, DateTimeKind.Local).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9103));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9318));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9443));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 176, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 178, DateTimeKind.Local).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 178, DateTimeKind.Local).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 259, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 260, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 260, DateTimeKind.Local).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 260, DateTimeKind.Local).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 287, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 287, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 287, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 287, DateTimeKind.Local).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 287, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 287, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 264, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 264, DateTimeKind.Local).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 264, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 264, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 264, DateTimeKind.Local).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 264, DateTimeKind.Local).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 189, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 189, DateTimeKind.Local).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 189, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 189, DateTimeKind.Local).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 189, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 189, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 189, DateTimeKind.Local).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 189, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 233, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 233, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 204, DateTimeKind.Local).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 204, DateTimeKind.Local).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 204, DateTimeKind.Local).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 219, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 222, DateTimeKind.Local).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 222, DateTimeKind.Local).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 209, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 209, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 209, DateTimeKind.Local).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 209, DateTimeKind.Local).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 209, DateTimeKind.Local).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 209, DateTimeKind.Local).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 209, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 209, DateTimeKind.Local).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 209, DateTimeKind.Local).AddTicks(9248));
        }
    }
}
