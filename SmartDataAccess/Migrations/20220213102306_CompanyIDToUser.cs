using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class CompanyIDToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyID",
                table: "Users",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 648, DateTimeKind.Local).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 648, DateTimeKind.Local).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 648, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 648, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 677, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 677, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 680, DateTimeKind.Local).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 680, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 653, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 653, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 653, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 653, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 653, DateTimeKind.Local).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(287));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(322));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(339));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(354));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(527));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(916));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(925));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1098));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1106));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1151));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1154));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1162));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1193));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1223));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(53));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(328));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(371));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(783));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(898));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1081));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7858));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 686, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 686, DateTimeKind.Local).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 686, DateTimeKind.Local).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 662, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 662, DateTimeKind.Local).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 662, DateTimeKind.Local).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 662, DateTimeKind.Local).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 662, DateTimeKind.Local).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 662, DateTimeKind.Local).AddTicks(9754));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 664, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 664, DateTimeKind.Local).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 664, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 664, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 669, DateTimeKind.Local).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 669, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 669, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 669, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 669, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 661, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 661, DateTimeKind.Local).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 661, DateTimeKind.Local).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 651, DateTimeKind.Local).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 651, DateTimeKind.Local).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "FundSources",
                keyColumn: "FundSourceID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 689, DateTimeKind.Local).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "FundSources",
                keyColumn: "FundSourceID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 690, DateTimeKind.Local).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "FundSources",
                keyColumn: "FundSourceID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 690, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 655, DateTimeKind.Local).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 655, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 682, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 682, DateTimeKind.Local).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 682, DateTimeKind.Local).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 682, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5614));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 35,
                columns: new[] { "LastChangedDate", "LayoutID" },
                values: new object[] { new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5653), 8 });

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 683, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 683, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 683, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 683, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 683, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 683, DateTimeKind.Local).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 683, DateTimeKind.Local).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 683, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 665, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 665, DateTimeKind.Local).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 665, DateTimeKind.Local).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 665, DateTimeKind.Local).AddTicks(6366));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 665, DateTimeKind.Local).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 665, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 665, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 665, DateTimeKind.Local).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 665, DateTimeKind.Local).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 665, DateTimeKind.Local).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 666, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 666, DateTimeKind.Local).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 666, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 666, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 666, DateTimeKind.Local).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 666, DateTimeKind.Local).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 666, DateTimeKind.Local).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 666, DateTimeKind.Local).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 666, DateTimeKind.Local).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9994,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 666, DateTimeKind.Local).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9995,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 666, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9996,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 666, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 644, DateTimeKind.Local).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 644, DateTimeKind.Local).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 644, DateTimeKind.Local).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 644, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 644, DateTimeKind.Local).AddTicks(1471));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 640, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 640, DateTimeKind.Local).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 640, DateTimeKind.Local).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 640, DateTimeKind.Local).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 640, DateTimeKind.Local).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 640, DateTimeKind.Local).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 640, DateTimeKind.Local).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 640, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(194));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1151));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1425));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1484));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1608));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1769));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1843));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(2113));

            migrationBuilder.UpdateData(
                table: "PinCodeTypes",
                keyColumn: "PinCodeTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 691, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "PinCodeTypes",
                keyColumn: "PinCodeTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 691, DateTimeKind.Local).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "PinCodeTypes",
                keyColumn: "PinCodeTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 691, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 658, DateTimeKind.Local).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 658, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 658, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 658, DateTimeKind.Local).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 679, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 679, DateTimeKind.Local).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 679, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 653, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 653, DateTimeKind.Local).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 653, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 653, DateTimeKind.Local).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 653, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 653, DateTimeKind.Local).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 653, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 672, DateTimeKind.Local).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 672, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 672, DateTimeKind.Local).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 672, DateTimeKind.Local).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 672, DateTimeKind.Local).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 672, DateTimeKind.Local).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 672, DateTimeKind.Local).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 672, DateTimeKind.Local).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 672, DateTimeKind.Local).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 672, DateTimeKind.Local).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 672, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 672, DateTimeKind.Local).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9755));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9903));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 642, DateTimeKind.Local).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 634, DateTimeKind.Local).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 637, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 637, DateTimeKind.Local).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 675, DateTimeKind.Local).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 675, DateTimeKind.Local).AddTicks(1279));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 675, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 675, DateTimeKind.Local).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 688, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 688, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 688, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 688, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 688, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 688, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 688, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 676, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 676, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 676, DateTimeKind.Local).AddTicks(4878));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 676, DateTimeKind.Local).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 676, DateTimeKind.Local).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 676, DateTimeKind.Local).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 646, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 646, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 646, DateTimeKind.Local).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 646, DateTimeKind.Local).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 646, DateTimeKind.Local).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 646, DateTimeKind.Local).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 646, DateTimeKind.Local).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 646, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 664, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 664, DateTimeKind.Local).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 652, DateTimeKind.Local).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 652, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 652, DateTimeKind.Local).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 659, DateTimeKind.Local).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 660, DateTimeKind.Local).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 660, DateTimeKind.Local).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 655, DateTimeKind.Local).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 655, DateTimeKind.Local).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 655, DateTimeKind.Local).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 655, DateTimeKind.Local).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 655, DateTimeKind.Local).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 655, DateTimeKind.Local).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 655, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 655, DateTimeKind.Local).AddTicks(2047));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 655, DateTimeKind.Local).AddTicks(2052));

            migrationBuilder.CreateIndex(
                name: "IX_Users_CompanyID",
                table: "Users",
                column: "CompanyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Companies_CompanyID",
                table: "Users",
                column: "CompanyID",
                principalTable: "Companies",
                principalColumn: "CompanyID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Companies_CompanyID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CompanyID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CompanyID",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 345, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 345, DateTimeKind.Local).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 345, DateTimeKind.Local).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 345, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 385, DateTimeKind.Local).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 386, DateTimeKind.Local).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 390, DateTimeKind.Local).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 390, DateTimeKind.Local).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 351, DateTimeKind.Local).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 351, DateTimeKind.Local).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 351, DateTimeKind.Local).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 351, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 351, DateTimeKind.Local).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7387));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7439));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7792));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 355, DateTimeKind.Local).AddTicks(9215));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7378));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7408));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7442));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7656));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 347, DateTimeKind.Local).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(7073));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 377, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 399, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 399, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 399, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 365, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 365, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 365, DateTimeKind.Local).AddTicks(1358));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 365, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 365, DateTimeKind.Local).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 365, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 366, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 367, DateTimeKind.Local).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 367, DateTimeKind.Local).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 367, DateTimeKind.Local).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 373, DateTimeKind.Local).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 373, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 373, DateTimeKind.Local).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 373, DateTimeKind.Local).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 373, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 363, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 363, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 363, DateTimeKind.Local).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 349, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 349, DateTimeKind.Local).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "FundSources",
                keyColumn: "FundSourceID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 403, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "FundSources",
                keyColumn: "FundSourceID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 403, DateTimeKind.Local).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "FundSources",
                keyColumn: "FundSourceID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 403, DateTimeKind.Local).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 353, DateTimeKind.Local).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 353, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 392, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 392, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 392, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 392, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 35,
                columns: new[] { "LastChangedDate", "LayoutID" },
                values: new object[] { new DateTime(2022, 2, 12, 20, 47, 50, 397, DateTimeKind.Local).AddTicks(7393), 7 });

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 394, DateTimeKind.Local).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 394, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 394, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 394, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 394, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 394, DateTimeKind.Local).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 394, DateTimeKind.Local).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 394, DateTimeKind.Local).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 368, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 368, DateTimeKind.Local).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 368, DateTimeKind.Local).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 368, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 368, DateTimeKind.Local).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 368, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 368, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 368, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 368, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 368, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 369, DateTimeKind.Local).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 369, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 369, DateTimeKind.Local).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 369, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 369, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 369, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 369, DateTimeKind.Local).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 369, DateTimeKind.Local).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 369, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9994,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 369, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9995,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 369, DateTimeKind.Local).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9996,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 369, DateTimeKind.Local).AddTicks(7439));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 342, DateTimeKind.Local).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 342, DateTimeKind.Local).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 342, DateTimeKind.Local).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 342, DateTimeKind.Local).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 342, DateTimeKind.Local).AddTicks(3607));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1764));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1769));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1773));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1822));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1837));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1841));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1847));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1882));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1935));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2173));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2213));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2237));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2257));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2324));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2445));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2522));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2539));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2559));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2589));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2609));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2634));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "PinCodeTypes",
                keyColumn: "PinCodeTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 405, DateTimeKind.Local).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "PinCodeTypes",
                keyColumn: "PinCodeTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 405, DateTimeKind.Local).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "PinCodeTypes",
                keyColumn: "PinCodeTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 405, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 358, DateTimeKind.Local).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 358, DateTimeKind.Local).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 358, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 358, DateTimeKind.Local).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 388, DateTimeKind.Local).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 388, DateTimeKind.Local).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 388, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 351, DateTimeKind.Local).AddTicks(9762));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 351, DateTimeKind.Local).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 351, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 351, DateTimeKind.Local).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 351, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 351, DateTimeKind.Local).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 351, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 378, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 378, DateTimeKind.Local).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 378, DateTimeKind.Local).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 378, DateTimeKind.Local).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 378, DateTimeKind.Local).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 378, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 378, DateTimeKind.Local).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 378, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 378, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 378, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 378, DateTimeKind.Local).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 378, DateTimeKind.Local).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7378));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7387));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7399));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7408));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7575));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7589));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 340, DateTimeKind.Local).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 335, DateTimeKind.Local).AddTicks(1176));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 337, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 337, DateTimeKind.Local).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 381, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 381, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 381, DateTimeKind.Local).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 381, DateTimeKind.Local).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 401, DateTimeKind.Local).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 401, DateTimeKind.Local).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 401, DateTimeKind.Local).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 401, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 401, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 401, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 401, DateTimeKind.Local).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 383, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 383, DateTimeKind.Local).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 383, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 383, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 383, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 383, DateTimeKind.Local).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 344, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 344, DateTimeKind.Local).AddTicks(2576));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 344, DateTimeKind.Local).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 344, DateTimeKind.Local).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 344, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 344, DateTimeKind.Local).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 344, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 344, DateTimeKind.Local).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 367, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 367, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 350, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 350, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 350, DateTimeKind.Local).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 359, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 361, DateTimeKind.Local).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 361, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 353, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 353, DateTimeKind.Local).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 353, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 353, DateTimeKind.Local).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 353, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 353, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 353, DateTimeKind.Local).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 353, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 12, 20, 47, 50, 353, DateTimeKind.Local).AddTicks(5546));
        }
    }
}
