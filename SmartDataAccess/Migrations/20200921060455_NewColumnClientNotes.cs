using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class NewColumnClientNotes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "VisibleToClient",
                table: "ClientNotes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 75, DateTimeKind.Local).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 75, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 75, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 75, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 86, DateTimeKind.Local).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 86, DateTimeKind.Local).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 86, DateTimeKind.Local).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 86, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 86, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 95, DateTimeKind.Local).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(42));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(66));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(109));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(194));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(647));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(898));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 96, DateTimeKind.Local).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5016));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5189));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5281));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5284));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5287));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5296));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5299));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5309));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5618));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 78, DateTimeKind.Local).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 88, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 88, DateTimeKind.Local).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 88, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 88, DateTimeKind.Local).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(647));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 137, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 109, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 110, DateTimeKind.Local).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 110, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 110, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 110, DateTimeKind.Local).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 110, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 114, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 114, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 114, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 131, DateTimeKind.Local).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 131, DateTimeKind.Local).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 131, DateTimeKind.Local).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 105, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 105, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 105, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 91, DateTimeKind.Local).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 91, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 120, DateTimeKind.Local).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 120, DateTimeKind.Local).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 120, DateTimeKind.Local).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 120, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 120, DateTimeKind.Local).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 120, DateTimeKind.Local).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 120, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 124, DateTimeKind.Local).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 124, DateTimeKind.Local).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 124, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 124, DateTimeKind.Local).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 124, DateTimeKind.Local).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 124, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 124, DateTimeKind.Local).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 124, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 124, DateTimeKind.Local).AddTicks(2257));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 124, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 124, DateTimeKind.Local).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 124, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 124, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 124, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 124, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 124, DateTimeKind.Local).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 124, DateTimeKind.Local).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 124, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 70, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 70, DateTimeKind.Local).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 70, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 70, DateTimeKind.Local).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 70, DateTimeKind.Local).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2676));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2774));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2895));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2954));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2958));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2968));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 67, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 97, DateTimeKind.Local).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 97, DateTimeKind.Local).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 97, DateTimeKind.Local).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 97, DateTimeKind.Local).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 81, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 81, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 81, DateTimeKind.Local).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 81, DateTimeKind.Local).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 81, DateTimeKind.Local).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 87, DateTimeKind.Local).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 87, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 87, DateTimeKind.Local).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 87, DateTimeKind.Local).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 87, DateTimeKind.Local).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3116));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3126));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3131));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3133));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3172));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3175));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3177));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3182));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3185));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3188));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3191));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 68, DateTimeKind.Local).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 60, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 90, DateTimeKind.Local).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 90, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 90, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 90, DateTimeKind.Local).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 90, DateTimeKind.Local).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 90, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 90, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 90, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 90, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 73, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 73, DateTimeKind.Local).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 73, DateTimeKind.Local).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 73, DateTimeKind.Local).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 73, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 115, DateTimeKind.Local).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 1 },
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 115, DateTimeKind.Local).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 85, DateTimeKind.Local).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 85, DateTimeKind.Local).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 85, DateTimeKind.Local).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 85, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 98, DateTimeKind.Local).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 101, DateTimeKind.Local).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 101, DateTimeKind.Local).AddTicks(9204));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 21, 8, 4, 54, 101, DateTimeKind.Local).AddTicks(9218));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VisibleToClient",
                table: "ClientNotes");

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 166, DateTimeKind.Local).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 166, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 166, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 166, DateTimeKind.Local).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 178, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 178, DateTimeKind.Local).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 178, DateTimeKind.Local).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 178, DateTimeKind.Local).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 178, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5433));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5842));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1934));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1958));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2145));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2158));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2173));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2209));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2257));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2266));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2443));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 180, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 180, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 180, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 180, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9903));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9987));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 213, DateTimeKind.Local).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 213, DateTimeKind.Local).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 213, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 213, DateTimeKind.Local).AddTicks(19));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 213, DateTimeKind.Local).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 213, DateTimeKind.Local).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 213, DateTimeKind.Local).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 213, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 213, DateTimeKind.Local).AddTicks(45));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 213, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 213, DateTimeKind.Local).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 213, DateTimeKind.Local).AddTicks(63));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 197, DateTimeKind.Local).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 197, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 197, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 197, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 197, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 197, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 199, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 200, DateTimeKind.Local).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 200, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 209, DateTimeKind.Local).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 209, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 209, DateTimeKind.Local).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 194, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 194, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 194, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 182, DateTimeKind.Local).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 182, DateTimeKind.Local).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 201, DateTimeKind.Local).AddTicks(9754));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 201, DateTimeKind.Local).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 201, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 201, DateTimeKind.Local).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 201, DateTimeKind.Local).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 201, DateTimeKind.Local).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 201, DateTimeKind.Local).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 157, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 158, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 158, DateTimeKind.Local).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 158, DateTimeKind.Local).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 158, DateTimeKind.Local).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 147, DateTimeKind.Local).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3011));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3462));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3475));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 187, DateTimeKind.Local).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 187, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 187, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 187, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 173, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 173, DateTimeKind.Local).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 173, DateTimeKind.Local).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 173, DateTimeKind.Local).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 173, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 179, DateTimeKind.Local).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 179, DateTimeKind.Local).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 179, DateTimeKind.Local).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 179, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 179, DateTimeKind.Local).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7792));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7834));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7836));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7867));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 140, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 182, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 182, DateTimeKind.Local).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 182, DateTimeKind.Local).AddTicks(656));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 182, DateTimeKind.Local).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 182, DateTimeKind.Local).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 182, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 182, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 182, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 182, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 162, DateTimeKind.Local).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 162, DateTimeKind.Local).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 162, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 162, DateTimeKind.Local).AddTicks(1634));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 162, DateTimeKind.Local).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 200, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 1 },
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 200, DateTimeKind.Local).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 177, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 177, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 177, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 177, DateTimeKind.Local).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 188, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 191, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 191, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 191, DateTimeKind.Local).AddTicks(8640));
        }
    }
}
