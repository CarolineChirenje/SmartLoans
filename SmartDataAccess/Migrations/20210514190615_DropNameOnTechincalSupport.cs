using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class DropNameOnTechincalSupport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TechnicalSupport_SupportLists_SupportListID",
                table: "TechnicalSupport");

            migrationBuilder.DropTable(
                name: "SupportLists");

            migrationBuilder.DropIndex(
                name: "IX_TechnicalSupport_SupportListID",
                table: "TechnicalSupport");

            migrationBuilder.DropColumn(
                name: "SupportListID",
                table: "TechnicalSupport");

            migrationBuilder.AddColumn<string>(
                name: "LastChangedBy",
                table: "TechnicalSupport",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastChangedDate",
                table: "TechnicalSupport",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 510, DateTimeKind.Local).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 510, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 510, DateTimeKind.Local).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 510, DateTimeKind.Local).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 557, DateTimeKind.Local).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 557, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 561, DateTimeKind.Local).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 561, DateTimeKind.Local).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 518, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 518, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 518, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 518, DateTimeKind.Local).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 518, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9318));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9452));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9615));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9709));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9728));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9731));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9755));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9766));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9811));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9837));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9858));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9873));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9964));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9987));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 524, DateTimeKind.Local).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(45));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(48));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(56));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(64));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(169));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(191));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(196));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(204));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 525, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 512, DateTimeKind.Local).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1634));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1657));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1662));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1738));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1744));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1755));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 568, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 568, DateTimeKind.Local).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 568, DateTimeKind.Local).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 534, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 534, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 534, DateTimeKind.Local).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 534, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 534, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 534, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 536, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 536, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 536, DateTimeKind.Local).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 536, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 545, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 545, DateTimeKind.Local).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 545, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 545, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 545, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 532, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 532, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 532, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 515, DateTimeKind.Local).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 515, DateTimeKind.Local).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 522, DateTimeKind.Local).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 522, DateTimeKind.Local).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 563, DateTimeKind.Local).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 563, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 563, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 563, DateTimeKind.Local).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 1,
                columns: new[] { "CSSClass", "LastChangedDate" },
                values: new object[] { "fa fa-bomb", new DateTime(2021, 5, 14, 21, 6, 13, 566, DateTimeKind.Local).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 566, DateTimeKind.Local).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 3,
                columns: new[] { "CSSClass", "LastChangedDate" },
                values: new object[] { "fa fa-cart-plus", new DateTime(2021, 5, 14, 21, 6, 13, 566, DateTimeKind.Local).AddTicks(9081) });

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 566, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 566, DateTimeKind.Local).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 566, DateTimeKind.Local).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 566, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 566, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 9,
                columns: new[] { "CSSClass", "LastChangedDate" },
                values: new object[] { "fa fa-address-book", new DateTime(2021, 5, 14, 21, 6, 13, 566, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 566, DateTimeKind.Local).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 566, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 12,
                columns: new[] { "CSSClass", "DisplayName", "LastChangedDate" },
                values: new object[] { "fa fa-gavel", "Finalised Deductions", new DateTime(2021, 5, 14, 21, 6, 13, 566, DateTimeKind.Local).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 565, DateTimeKind.Local).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 565, DateTimeKind.Local).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 538, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 538, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 538, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 538, DateTimeKind.Local).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 538, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 538, DateTimeKind.Local).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 538, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 538, DateTimeKind.Local).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 540, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 540, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 540, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 540, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                columns: new[] { "CSSClass", "LastChangedDate" },
                values: new object[] { "fa fa-bomb", new DateTime(2021, 5, 14, 21, 6, 13, 540, DateTimeKind.Local).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 540, DateTimeKind.Local).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 540, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 540, DateTimeKind.Local).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 540, DateTimeKind.Local).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 540, DateTimeKind.Local).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 540, DateTimeKind.Local).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 540, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 540, DateTimeKind.Local).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 540, DateTimeKind.Local).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 540, DateTimeKind.Local).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 540, DateTimeKind.Local).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 540, DateTimeKind.Local).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 540, DateTimeKind.Local).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 540, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9995,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 540, DateTimeKind.Local).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9996,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 540, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9997,
                columns: new[] { "CSSClass", "LastChangedDate" },
                values: new object[] { "fa fa-wrench", new DateTime(2021, 5, 14, 21, 6, 13, 540, DateTimeKind.Local).AddTicks(9522) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 540, DateTimeKind.Local).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 540, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuID", "ActionName", "CSSClass", "ControllerName", "DisplayName", "IsActive", "LastChangedBy", "LastChangedDate", "MenuGroupID", "OrderNo" },
                values: new object[] { 9994, "Support", "fa fa-anchor", "Support", "Support", true, "SuperUser", new DateTime(2021, 5, 14, 21, 6, 13, 540, DateTimeKind.Local).AddTicks(9511), 999, 9994 });

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 504, DateTimeKind.Local).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 504, DateTimeKind.Local).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 504, DateTimeKind.Local).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 504, DateTimeKind.Local).AddTicks(7489));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 504, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8671));

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionID", "Description", "IsActive", "IsDeleted", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 141, null, true, false, "SuperUser", new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8698), "View Maintanances" },
                    { 142, null, true, false, "SuperUser", new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8703), "View Technical Support Settings" },
                    { 138, null, true, false, "SuperUser", new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8685), "View Feature Flag" },
                    { 139, null, true, false, "SuperUser", new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8689), "View Layouts" },
                    { 137, null, true, false, "SuperUser", new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8680), "View Currency" },
                    { 140, null, true, false, "SuperUser", new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8694), "View Licences" },
                    { 136, null, true, false, "SuperUser", new DateTime(2021, 5, 14, 21, 6, 13, 501, DateTimeKind.Local).AddTicks(8675), "View Country" }
                });

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 527, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 527, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 527, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 527, DateTimeKind.Local).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 559, DateTimeKind.Local).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 559, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 559, DateTimeKind.Local).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 519, DateTimeKind.Local).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 519, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 519, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 519, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 519, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 519, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 519, DateTimeKind.Local).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(6147), 9995 });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(6149), 9996 });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 23,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(6151), 9997 });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 24,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(6152), 9998 });

            migrationBuilder.InsertData(
                table: "RoleMenus",
                columns: new[] { "RoleMenuID", "LastChangedBy", "LastChangedDate", "MenuID", "RoleID" },
                values: new object[] { 25, "SuperUser", new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(6154), 9999, 1 });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4528));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 496, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 497, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 497, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 553, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 553, DateTimeKind.Local).AddTicks(8068));

            migrationBuilder.InsertData(
                table: "TechnicalSupport",
                columns: new[] { "TechnicalSupportID", "LastChangedBy", "LastChangedDate", "Name", "Value" },
                values: new object[,]
                {
                    { 5, "SuperUser", new DateTime(2021, 5, 14, 21, 6, 13, 570, DateTimeKind.Local).AddTicks(9314), "{ ID = Whatsapp Support Message, Name = Whatsapp Support Message }", "" },
                    { 6, "SuperUser", new DateTime(2021, 5, 14, 21, 6, 13, 570, DateTimeKind.Local).AddTicks(9328), "{ ID = Database Server IP, Name = Database Server IP }", "" },
                    { 2, "SuperUser", new DateTime(2021, 5, 14, 21, 6, 13, 570, DateTimeKind.Local).AddTicks(9281), "{ ID = Company Registration Link, Name = Company Registration Link }", "" },
                    { 1, "SuperUser", new DateTime(2021, 5, 14, 21, 6, 13, 570, DateTimeKind.Local).AddTicks(8910), "{ ID = CompanyName, Name = CompanyName }", "" },
                    { 4, "SuperUser", new DateTime(2021, 5, 14, 21, 6, 13, 570, DateTimeKind.Local).AddTicks(9304), "{ ID = Website, Name = Website }", "" },
                    { 3, "SuperUser", new DateTime(2021, 5, 14, 21, 6, 13, 570, DateTimeKind.Local).AddTicks(9295), "{ ID = Mobile Number, Name = Mobile Number }", "" }
                });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 555, DateTimeKind.Local).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 555, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 555, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 555, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 555, DateTimeKind.Local).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 555, DateTimeKind.Local).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 507, DateTimeKind.Local).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 507, DateTimeKind.Local).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 507, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 507, DateTimeKind.Local).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 507, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 507, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 507, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 507, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 537, DateTimeKind.Local).AddTicks(2497));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 537, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 517, DateTimeKind.Local).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 517, DateTimeKind.Local).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 517, DateTimeKind.Local).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 528, DateTimeKind.Local).AddTicks(2153));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 530, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 530, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 521, DateTimeKind.Local).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 521, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 521, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 521, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 521, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 521, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 521, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 521, DateTimeKind.Local).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 14, 21, 6, 13, 521, DateTimeKind.Local).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2021, 5, 14, 21, 6, 13, 549, DateTimeKind.Local).AddTicks(6146), 9994 });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "RolePermissionID", "LastChangedBy", "LastChangedDate", "PermissionID", "RoleID" },
                values: new object[,]
                {
                    { 136, "SuperUser", new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4874), 136, 1 },
                    { 137, "SuperUser", new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4876), 137, 1 },
                    { 138, "SuperUser", new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4878), 138, 1 },
                    { 139, "SuperUser", new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4879), 139, 1 },
                    { 140, "SuperUser", new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4881), 140, 1 },
                    { 141, "SuperUser", new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4883), 141, 1 },
                    { 142, "SuperUser", new DateTime(2021, 5, 14, 21, 6, 13, 502, DateTimeKind.Local).AddTicks(4885), 142, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9994);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 142);

            migrationBuilder.DropColumn(
                name: "LastChangedBy",
                table: "TechnicalSupport");

            migrationBuilder.DropColumn(
                name: "LastChangedDate",
                table: "TechnicalSupport");

            migrationBuilder.AddColumn<int>(
                name: "SupportListID",
                table: "TechnicalSupport",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SupportLists",
                columns: table => new
                {
                    SupportListID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastChangedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportLists", x => x.SupportListID);
                });

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 438, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 438, DateTimeKind.Local).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 438, DateTimeKind.Local).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 438, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 488, DateTimeKind.Local).AddTicks(1633));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 488, DateTimeKind.Local).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 492, DateTimeKind.Local).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 492, DateTimeKind.Local).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 448, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 448, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 448, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 448, DateTimeKind.Local).AddTicks(6324));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 448, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7489));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7619));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7796));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7802));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7834));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8033));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 455, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4897));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4952));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(4966));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 441, DateTimeKind.Local).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 479, DateTimeKind.Local).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 500, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 500, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 500, DateTimeKind.Local).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 465, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 465, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 465, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 465, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 465, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 465, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 467, DateTimeKind.Local).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 467, DateTimeKind.Local).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 467, DateTimeKind.Local).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 467, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 475, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 475, DateTimeKind.Local).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 475, DateTimeKind.Local).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 475, DateTimeKind.Local).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 475, DateTimeKind.Local).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 463, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 463, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 463, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 444, DateTimeKind.Local).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 444, DateTimeKind.Local).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 453, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 453, DateTimeKind.Local).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 493, DateTimeKind.Local).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 493, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 493, DateTimeKind.Local).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 493, DateTimeKind.Local).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 1,
                columns: new[] { "CSSClass", "LastChangedDate" },
                values: new object[] { "fas fa-star", new DateTime(2021, 5, 9, 13, 41, 26, 497, DateTimeKind.Local).AddTicks(3454) });

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 497, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 3,
                columns: new[] { "CSSClass", "LastChangedDate" },
                values: new object[] { "fas fa-battery-empty", new DateTime(2021, 5, 9, 13, 41, 26, 497, DateTimeKind.Local).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 497, DateTimeKind.Local).AddTicks(3597));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 497, DateTimeKind.Local).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 497, DateTimeKind.Local).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 497, DateTimeKind.Local).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 497, DateTimeKind.Local).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 9,
                columns: new[] { "CSSClass", "LastChangedDate" },
                values: new object[] { "fas fa-address-book", new DateTime(2021, 5, 9, 13, 41, 26, 497, DateTimeKind.Local).AddTicks(3621) });

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 497, DateTimeKind.Local).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 497, DateTimeKind.Local).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 12,
                columns: new[] { "CSSClass", "DisplayName", "LastChangedDate" },
                values: new object[] { "fas fa-copy", "Deductions", new DateTime(2021, 5, 9, 13, 41, 26, 497, DateTimeKind.Local).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 496, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 496, DateTimeKind.Local).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 469, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 469, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 469, DateTimeKind.Local).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 469, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 469, DateTimeKind.Local).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 469, DateTimeKind.Local).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 469, DateTimeKind.Local).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 469, DateTimeKind.Local).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 471, DateTimeKind.Local).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 471, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 471, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 471, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                columns: new[] { "CSSClass", "LastChangedDate" },
                values: new object[] { "fa fa-star", new DateTime(2021, 5, 9, 13, 41, 26, 471, DateTimeKind.Local).AddTicks(4686) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 471, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 471, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 471, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 471, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 471, DateTimeKind.Local).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 471, DateTimeKind.Local).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 471, DateTimeKind.Local).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 471, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 471, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 471, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 471, DateTimeKind.Local).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 471, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 471, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 471, DateTimeKind.Local).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9995,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 471, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9996,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 471, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9997,
                columns: new[] { "CSSClass", "LastChangedDate" },
                values: new object[] { "fa  fa-wrench", new DateTime(2021, 5, 9, 13, 41, 26, 471, DateTimeKind.Local).AddTicks(4753) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 471, DateTimeKind.Local).AddTicks(4756));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 471, DateTimeKind.Local).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 431, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 431, DateTimeKind.Local).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 431, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 431, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 431, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7387));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7442));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7589));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 427, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 457, DateTimeKind.Local).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 457, DateTimeKind.Local).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 457, DateTimeKind.Local).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 457, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 490, DateTimeKind.Local).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 490, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 490, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 449, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 449, DateTimeKind.Local).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 449, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 449, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 449, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 449, DateTimeKind.Local).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 449, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 480, DateTimeKind.Local).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 480, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 480, DateTimeKind.Local).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 480, DateTimeKind.Local).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 480, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 480, DateTimeKind.Local).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 480, DateTimeKind.Local).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 480, DateTimeKind.Local).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 480, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 480, DateTimeKind.Local).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 480, DateTimeKind.Local).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 480, DateTimeKind.Local).AddTicks(2589));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 480, DateTimeKind.Local).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 480, DateTimeKind.Local).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 480, DateTimeKind.Local).AddTicks(2593));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 480, DateTimeKind.Local).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 480, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 480, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 480, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2021, 5, 9, 13, 41, 26, 480, DateTimeKind.Local).AddTicks(2603), 9996 });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2021, 5, 9, 13, 41, 26, 480, DateTimeKind.Local).AddTicks(2605), 9997 });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 23,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2021, 5, 9, 13, 41, 26, 480, DateTimeKind.Local).AddTicks(2606), 9998 });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 24,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2021, 5, 9, 13, 41, 26, 480, DateTimeKind.Local).AddTicks(2608), 9999 });

            migrationBuilder.InsertData(
                table: "RoleMenus",
                columns: new[] { "RoleMenuID", "LastChangedBy", "LastChangedDate", "MenuID", "RoleID" },
                values: new object[] { 20, "SuperUser", new DateTime(2021, 5, 9, 13, 41, 26, 480, DateTimeKind.Local).AddTicks(2602), 9995, 1 });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7802));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7893));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 428, DateTimeKind.Local).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 420, DateTimeKind.Local).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 422, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 422, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 484, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 484, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.InsertData(
                table: "SupportLists",
                columns: new[] { "SupportListID", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 2, "SuperUser", new DateTime(2021, 5, 9, 13, 41, 26, 499, DateTimeKind.Local).AddTicks(2486), "CompanyRegistrationLink" },
                    { 1, "SuperUser", new DateTime(2021, 5, 9, 13, 41, 26, 499, DateTimeKind.Local).AddTicks(2166), "CompanyName" },
                    { 3, "SuperUser", new DateTime(2021, 5, 9, 13, 41, 26, 499, DateTimeKind.Local).AddTicks(2492), "MobileNumber" },
                    { 4, "SuperUser", new DateTime(2021, 5, 9, 13, 41, 26, 499, DateTimeKind.Local).AddTicks(2495), "Website" }
                });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 486, DateTimeKind.Local).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 486, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 486, DateTimeKind.Local).AddTicks(2153));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 486, DateTimeKind.Local).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 486, DateTimeKind.Local).AddTicks(2158));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 486, DateTimeKind.Local).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 435, DateTimeKind.Local).AddTicks(5503));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 435, DateTimeKind.Local).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 435, DateTimeKind.Local).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 435, DateTimeKind.Local).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 435, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 435, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 435, DateTimeKind.Local).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 435, DateTimeKind.Local).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 467, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 467, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 447, DateTimeKind.Local).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 447, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 447, DateTimeKind.Local).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 458, DateTimeKind.Local).AddTicks(2945));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 460, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 460, DateTimeKind.Local).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 453, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 453, DateTimeKind.Local).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 453, DateTimeKind.Local).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 453, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 453, DateTimeKind.Local).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 453, DateTimeKind.Local).AddTicks(1156));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 453, DateTimeKind.Local).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 453, DateTimeKind.Local).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 9, 13, 41, 26, 453, DateTimeKind.Local).AddTicks(1192));

            migrationBuilder.CreateIndex(
                name: "IX_TechnicalSupport_SupportListID",
                table: "TechnicalSupport",
                column: "SupportListID");

            migrationBuilder.AddForeignKey(
                name: "FK_TechnicalSupport_SupportLists_SupportListID",
                table: "TechnicalSupport",
                column: "SupportListID",
                principalTable: "SupportLists",
                principalColumn: "SupportListID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
