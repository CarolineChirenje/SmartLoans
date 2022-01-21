using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class LayoutChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9997);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999);

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 866, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 866, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 866, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 866, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 911, DateTimeKind.Local).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 911, DateTimeKind.Local).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 916, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 916, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 872, DateTimeKind.Local).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 872, DateTimeKind.Local).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 872, DateTimeKind.Local).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 872, DateTimeKind.Local).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 872, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1094));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1106));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1149));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1154));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1356));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1392));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1482));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1581));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1586));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1596));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1606));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1611));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1631));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1656));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1936));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2005));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2413));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2449));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2584));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2589));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2609));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 877, DateTimeKind.Local).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6477));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 868, DateTimeKind.Local).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 897, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 928, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 928, DateTimeKind.Local).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 928, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 883, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 883, DateTimeKind.Local).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 883, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 883, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 883, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 883, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 885, DateTimeKind.Local).AddTicks(1935));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 885, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 885, DateTimeKind.Local).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 885, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 891, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 891, DateTimeKind.Local).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 891, DateTimeKind.Local).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 891, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 891, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 881, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 881, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 881, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 870, DateTimeKind.Local).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 870, DateTimeKind.Local).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "FundSources",
                keyColumn: "FundSourceID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 932, DateTimeKind.Local).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "FundSources",
                keyColumn: "FundSourceID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 932, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "FundSources",
                keyColumn: "FundSourceID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 932, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 874, DateTimeKind.Local).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 874, DateTimeKind.Local).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 920, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 920, DateTimeKind.Local).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 920, DateTimeKind.Local).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 920, DateTimeKind.Local).AddTicks(1581));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 925, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 925, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 925, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 925, DateTimeKind.Local).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 925, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 925, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 925, DateTimeKind.Local).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 925, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 925, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 925, DateTimeKind.Local).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 925, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 925, DateTimeKind.Local).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 925, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 925, DateTimeKind.Local).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 925, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 925, DateTimeKind.Local).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 923, DateTimeKind.Local).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 923, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 923, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.InsertData(
                table: "Layouts",
                columns: new[] { "LayoutID", "DisplayName", "LastChangedBy", "LastChangedDate" },
                values: new object[] { 4, "Developer Menu", "SuperUser", new DateTime(2022, 1, 21, 18, 32, 36, 923, DateTimeKind.Local).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 886, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 886, DateTimeKind.Local).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 886, DateTimeKind.Local).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 886, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 886, DateTimeKind.Local).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 886, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 886, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 886, DateTimeKind.Local).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 886, DateTimeKind.Local).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 886, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 888, DateTimeKind.Local).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 888, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 888, DateTimeKind.Local).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 888, DateTimeKind.Local).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 888, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 888, DateTimeKind.Local).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 888, DateTimeKind.Local).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 888, DateTimeKind.Local).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 888, DateTimeKind.Local).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 888, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 888, DateTimeKind.Local).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 888, DateTimeKind.Local).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 888, DateTimeKind.Local).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 888, DateTimeKind.Local).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 888, DateTimeKind.Local).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 888, DateTimeKind.Local).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 888, DateTimeKind.Local).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 888, DateTimeKind.Local).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 888, DateTimeKind.Local).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 888, DateTimeKind.Local).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 888, DateTimeKind.Local).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 888, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9994,
                columns: new[] { "ActionName", "CSSClass", "ControllerName", "DisplayName", "LastChangedDate" },
                values: new object[] { "Dashboard", "fa fa-desktop", "FeatureFlag", "Technical Menu", new DateTime(2022, 1, 21, 18, 32, 36, 888, DateTimeKind.Local).AddTicks(3994) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9995,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 888, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9996,
                columns: new[] { "ActionName", "CSSClass", "ControllerName", "DisplayName", "LastChangedDate", "MenuGroupID" },
                values: new object[] { "MainMenu", "fa fa-book", "Menus", "Main Menu", new DateTime(2022, 1, 21, 18, 32, 36, 888, DateTimeKind.Local).AddTicks(4002), 9998 });

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 862, DateTimeKind.Local).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 862, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 862, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 862, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 862, DateTimeKind.Local).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1935));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1958));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2005));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2097));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2173));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2207));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2226));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2457));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2555));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2571));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2576));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2634));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2638));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 878, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 878, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 878, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 878, DateTimeKind.Local).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 913, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 913, DateTimeKind.Local).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 913, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 873, DateTimeKind.Local).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 873, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 873, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 873, DateTimeKind.Local).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 873, DateTimeKind.Local).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 873, DateTimeKind.Local).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 873, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 898, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 898, DateTimeKind.Local).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 898, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 898, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 898, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 898, DateTimeKind.Local).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 898, DateTimeKind.Local).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 898, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 898, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 898, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 898, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 898, DateTimeKind.Local).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 898, DateTimeKind.Local).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 898, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 898, DateTimeKind.Local).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 898, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 898, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 898, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 898, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 898, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 898, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 898, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 898, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 898, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 898, DateTimeKind.Local).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7834));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7836));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 860, DateTimeKind.Local).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 854, DateTimeKind.Local).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 857, DateTimeKind.Local).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 857, DateTimeKind.Local).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 905, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 905, DateTimeKind.Local).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 905, DateTimeKind.Local).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 905, DateTimeKind.Local).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 930, DateTimeKind.Local).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 930, DateTimeKind.Local).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 930, DateTimeKind.Local).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 930, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 930, DateTimeKind.Local).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 930, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 908, DateTimeKind.Local).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 908, DateTimeKind.Local).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 908, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 908, DateTimeKind.Local).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 908, DateTimeKind.Local).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 908, DateTimeKind.Local).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 864, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 864, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 864, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 864, DateTimeKind.Local).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 864, DateTimeKind.Local).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 864, DateTimeKind.Local).AddTicks(9728));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 864, DateTimeKind.Local).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 864, DateTimeKind.Local).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 885, DateTimeKind.Local).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 885, DateTimeKind.Local).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 871, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 871, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 871, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 879, DateTimeKind.Local).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 880, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 880, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 874, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 874, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 874, DateTimeKind.Local).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 874, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 874, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 874, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 874, DateTimeKind.Local).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 874, DateTimeKind.Local).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 21, 18, 32, 36, 874, DateTimeKind.Local).AddTicks(5176));

            migrationBuilder.InsertData(
                table: "LayoutMenus",
                columns: new[] { "LayoutMenuID", "ActionName", "CSSClass", "ControllerName", "DisplayName", "IsActive", "LastChangedBy", "LastChangedDate", "LayoutID", "LinkRequiresID", "OrderNo" },
                values: new object[,]
                {
                    { 17, "Support", "fa fa-anchor", "Support", "Support", true, "SuperUser", new DateTime(2022, 1, 21, 18, 32, 36, 925, DateTimeKind.Local).AddTicks(7315), 4, true, 17 },
                    { 18, "Licence", "fa  fa-key", "Licence", "Licence", true, "SuperUser", new DateTime(2022, 1, 21, 18, 32, 36, 925, DateTimeKind.Local).AddTicks(7330), 4, true, 18 },
                    { 19, "Maintanance", "fa fa-wrench", "Maintanance", "Maintanance", true, "SuperUser", new DateTime(2022, 1, 21, 18, 32, 36, 925, DateTimeKind.Local).AddTicks(7339), 4, true, 19 },
                    { 20, "FeatureFlag", "fa fa-building", "FeatureFlag", "Feature Flags", true, "SuperUser", new DateTime(2022, 1, 21, 18, 32, 36, 925, DateTimeKind.Local).AddTicks(7347), 4, true, 9999 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 37, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 37, DateTimeKind.Local).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 37, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 37, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 67, DateTimeKind.Local).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 67, DateTimeKind.Local).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 70, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 70, DateTimeKind.Local).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 42, DateTimeKind.Local).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 42, DateTimeKind.Local).AddTicks(264));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 42, DateTimeKind.Local).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 42, DateTimeKind.Local).AddTicks(186));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 42, DateTimeKind.Local).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(779));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(788));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(955));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(959));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(991));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1201));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1224));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1248));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1276));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1289));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1309));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1329));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1408));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1422));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1482));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1581));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1585));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1589));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1592));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 46, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 38, DateTimeKind.Local).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 60, DateTimeKind.Local).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 60, DateTimeKind.Local).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 60, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 60, DateTimeKind.Local).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 60, DateTimeKind.Local).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 60, DateTimeKind.Local).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 60, DateTimeKind.Local).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 60, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 60, DateTimeKind.Local).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(42));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 60, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 60, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(56));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(62));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 60, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(207));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 78, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 78, DateTimeKind.Local).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 78, DateTimeKind.Local).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 51, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 51, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 51, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 51, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 51, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 51, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 52, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 52, DateTimeKind.Local).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 52, DateTimeKind.Local).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 52, DateTimeKind.Local).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 58, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 58, DateTimeKind.Local).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 58, DateTimeKind.Local).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 58, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 58, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 50, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 50, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 50, DateTimeKind.Local).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 40, DateTimeKind.Local).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 40, DateTimeKind.Local).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "FundSources",
                keyColumn: "FundSourceID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 82, DateTimeKind.Local).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "FundSources",
                keyColumn: "FundSourceID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 82, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "FundSources",
                keyColumn: "FundSourceID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 82, DateTimeKind.Local).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 44, DateTimeKind.Local).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 44, DateTimeKind.Local).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 72, DateTimeKind.Local).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 72, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 72, DateTimeKind.Local).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 72, DateTimeKind.Local).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 75, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 75, DateTimeKind.Local).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 75, DateTimeKind.Local).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 75, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 75, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 75, DateTimeKind.Local).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 75, DateTimeKind.Local).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 75, DateTimeKind.Local).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 75, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 75, DateTimeKind.Local).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 75, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 75, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 75, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 75, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 75, DateTimeKind.Local).AddTicks(9768));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 75, DateTimeKind.Local).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 73, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 73, DateTimeKind.Local).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 73, DateTimeKind.Local).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 54, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 54, DateTimeKind.Local).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 54, DateTimeKind.Local).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 54, DateTimeKind.Local).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 54, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 54, DateTimeKind.Local).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 54, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 54, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 54, DateTimeKind.Local).AddTicks(1142));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 54, DateTimeKind.Local).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 55, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 55, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 55, DateTimeKind.Local).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 55, DateTimeKind.Local).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 55, DateTimeKind.Local).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 55, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 55, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 55, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 55, DateTimeKind.Local).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 55, DateTimeKind.Local).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 55, DateTimeKind.Local).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 55, DateTimeKind.Local).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 55, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 55, DateTimeKind.Local).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 55, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 55, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 55, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 55, DateTimeKind.Local).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 55, DateTimeKind.Local).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 55, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 55, DateTimeKind.Local).AddTicks(5906));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 55, DateTimeKind.Local).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9994,
                columns: new[] { "ActionName", "CSSClass", "ControllerName", "DisplayName", "LastChangedDate" },
                values: new object[] { "Support", "fa fa-anchor", "Support", "Support", new DateTime(2022, 1, 20, 19, 20, 1, 55, DateTimeKind.Local).AddTicks(5913) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9995,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 55, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9996,
                columns: new[] { "ActionName", "CSSClass", "ControllerName", "DisplayName", "LastChangedDate", "MenuGroupID" },
                values: new object[] { "Licence", "fa  fa-key", "Licence", "Licence", new DateTime(2022, 1, 20, 19, 20, 1, 55, DateTimeKind.Local).AddTicks(5921), 999 });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuID", "ActionName", "CSSClass", "ControllerName", "DisplayName", "IsActive", "LastChangedBy", "LastChangedDate", "MenuGroupID", "OrderNo" },
                values: new object[,]
                {
                    { 9999, "FeatureFlag", "fa fa-building", "FeatureFlag", "Feature Flags", true, "SuperUser", new DateTime(2022, 1, 20, 19, 20, 1, 55, DateTimeKind.Local).AddTicks(5932), 999, 9999 },
                    { 9998, "MainMenu", "fa fa-book", "Menus", "Main Menu", true, "SuperUser", new DateTime(2022, 1, 20, 19, 20, 1, 55, DateTimeKind.Local).AddTicks(5928), 9998, 9998 },
                    { 9997, "Maintanance", "fa fa-wrench", "Maintanance", "Maintanance", true, "SuperUser", new DateTime(2022, 1, 20, 19, 20, 1, 55, DateTimeKind.Local).AddTicks(5925), 999, 9997 }
                });

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 34, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 34, DateTimeKind.Local).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 34, DateTimeKind.Local).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 34, DateTimeKind.Local).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 34, DateTimeKind.Local).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4489));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4885));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4952));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4977));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 47, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 47, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 47, DateTimeKind.Local).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 47, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 69, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 69, DateTimeKind.Local).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 69, DateTimeKind.Local).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 42, DateTimeKind.Local).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 42, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 42, DateTimeKind.Local).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 42, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 42, DateTimeKind.Local).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 42, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 42, DateTimeKind.Local).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(2955));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(2958));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9318));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9552));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9615));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9642));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9654));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9677));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 32, DateTimeKind.Local).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 27, DateTimeKind.Local).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 30, DateTimeKind.Local).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 30, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 64, DateTimeKind.Local).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 64, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 64, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 64, DateTimeKind.Local).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 80, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 80, DateTimeKind.Local).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 80, DateTimeKind.Local).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 80, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 80, DateTimeKind.Local).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 80, DateTimeKind.Local).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 66, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 66, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 66, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 66, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 66, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 66, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 36, DateTimeKind.Local).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 36, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 36, DateTimeKind.Local).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 36, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 36, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 36, DateTimeKind.Local).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 36, DateTimeKind.Local).AddTicks(1289));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 36, DateTimeKind.Local).AddTicks(1326));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 53, DateTimeKind.Local).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 53, DateTimeKind.Local).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 41, DateTimeKind.Local).AddTicks(5223));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 41, DateTimeKind.Local).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 41, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 47, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 48, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 48, DateTimeKind.Local).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 43, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 43, DateTimeKind.Local).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 43, DateTimeKind.Local).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 43, DateTimeKind.Local).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 43, DateTimeKind.Local).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 43, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 43, DateTimeKind.Local).AddTicks(9858));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 43, DateTimeKind.Local).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 20, 19, 20, 1, 43, DateTimeKind.Local).AddTicks(9866));

            migrationBuilder.InsertData(
                table: "RoleMenus",
                columns: new[] { "RoleMenuID", "LastChangedBy", "LastChangedDate", "MenuID", "RoleID" },
                values: new object[] { 26, "SuperUser", new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(2971), 9997, 1 });

            migrationBuilder.InsertData(
                table: "RoleMenus",
                columns: new[] { "RoleMenuID", "LastChangedBy", "LastChangedDate", "MenuID", "RoleID" },
                values: new object[] { 27, "SuperUser", new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(2974), 9998, 1 });

            migrationBuilder.InsertData(
                table: "RoleMenus",
                columns: new[] { "RoleMenuID", "LastChangedBy", "LastChangedDate", "MenuID", "RoleID" },
                values: new object[] { 28, "SuperUser", new DateTime(2022, 1, 20, 19, 20, 1, 61, DateTimeKind.Local).AddTicks(2977), 9999, 1 });
        }
    }
}
